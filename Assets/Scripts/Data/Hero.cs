using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//mechanics 
// move
// sense
// action 
// rotate - internal 

// pos
// orientation 

// vis representation
    // tile 
    // arrow - to show direction

public class Hero : MonoBehaviour, IInitable
{
   Vector2Int m_Position = new Vector2Int();
   Orientation m_Orientation;

   MainLogic m_Logic;

#region callbacks
    // moved 
    // rotated 
    // sensed
    // action made 

#endregion

   public void Init(MainLogic logic){

       m_Logic = logic;

        //    logic.GetInputManager(). 
        // subs
   }

    public void Put(Vector3 pos){
        transform.position = pos;
    }

    Vector3 m_TmpPos;
    Vector3Int m_TilePos;
    public void Put(int toX, int toY, Orientation ori){
        m_Position.x = toX;
        m_Position.y = toY;

        m_TilePos.x = toX;
        m_TilePos.y = toY;
        m_TilePos.z = 0;

        m_TmpPos = m_Logic.GetLevel().GetTileMap().GetCellCenterWorld(m_TilePos);
        transform.position = m_TmpPos;

        PutCamera(m_TmpPos);

        Rotate(ori);
    }

    // test
    void PutCamera(Vector3 pos){

        pos.z = -10;

        Camera.main.transform.position = pos;

    }

    public void Put(int x, int y){
        m_Position.x = x;
        m_Position.y = x;

    }

    float c_AngleInitialDisplace = 90; // because initial pos for line is upward, rather than aligned with X axis 

    void Rotate(Orientation ori){
        m_Orientation = ori;

        int dx = 0;
        int dy = 0;

        LevelHelper.OrientationToDirection(out dx, out dy, m_Orientation);

        float angle = Mathf.Atan2(dy, dx) * Mathf.Rad2Deg - c_AngleInitialDisplace;

        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    public void Move(Orientation ori){

        bool canMove = m_Logic.GetLevel().CanMove(m_Position.x, m_Position.y, ori);
        if (canMove){
            int toX = m_Position.x;
            int toY = m_Position.y;

            LevelHelper.GetNextCellCoords(ref toX, ref toY, ori);

            Debug.Log("move " + ori);
            Put(toX, toY, ori);

            // event 
        }
        else{
            Debug.Log("can't move but at least rotate");
            Rotate(ori);

            // event
        }
    }


   void TryMove(){

       // having curr pos & orientation,
       // we construct x, y to move to 
       int x = 0;
       int y = 0;

       // N, S, W, E, x, y

       bool canMove = m_Logic.GetLevel().CanMove(x, y);
       if (canMove){

           // sound
       }
       else{

           // sound 
       }
       // Rotate 
   }

   void TrySense(){

   }

   void Action(){

   }

   void FloorAction(){

   }
}
