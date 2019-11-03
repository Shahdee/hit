using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public enum Orientation{
        None = 0, // we don't care how this one is oriented, ex. - wall or night table
        North,
        South,
        West,
        East
    }

    // {"st": [-1,-1], "ed": [1,1], "or": 0} // rect object
    // {"st": [-1,-1], "ed": [-1,-1], "or": 0} // 1 cell object 


    // TODO - I forgot how to work with struct
    public class Location{

        public const int c_LocationSize = 2;

        int [] m_Start;
        int [] m_End;

        Orientation m_Orientation;

        public Orientation GetOrientation(){
            return m_Orientation;
        }

        public int[] GetStart(){
            return m_Start;
        }

        public int[] GetEnd(){
            return m_End;
        }

        public bool isOneCell(){
            return (m_Start[0] == m_End[0] && m_Start[1] == m_End[1]);
        }

        public void Set(int[] start, int[] end, Orientation ori){
            m_Start = start;
            m_End = end;
            m_Orientation = ori;
        }
    }

public class Object
{
   // sound 
   
   // action
   // sense 

   // position
   // orientation
   // traversable
   // actionable 

   public enum ObjectType{
       Wall = 0,
       Door = 1,
       Carpet = 2,
       Wardrobe = 3,
       Bed = 4,
       Table = 5,
       Floor = 6,
   }

   bool m_Traversable;

//    ObjectType m_ObjType;

   Orientation m_Orientation;

   Location m_Location = new Location();

   public virtual ObjectType GetObjType(){
       return ObjectType.Wall;
   }

   public Orientation GetOrientation(){
       return m_Orientation;
   }

   public Location GetLocation(){
       return m_Location;
   }

   public void Put(int[] start, int[] end, Orientation ori){
       m_Location.Set(start, end, ori);
   }
    
    // checks of object occupies the spec. position 
   public bool isHere(int x, int y){

       if (m_Location.isOneCell()){
           int[] st = m_Location.GetStart();

           return (x == st[0] && y == st[1]);
       }
       else{
           int[] st = m_Location.GetStart();
           int[] ed = m_Location.GetEnd();

            return (x >= st[0] &&
                    y >= st[1] &&
                    x <= ed[0] &&
                    y <= ed[1]);
       }
   }

   public virtual bool isTraversable(){
    //    return m_Traversable;
        return false;
   }

    public void PerformSense(){

   }

   public void PerformAction(){

   }
}
