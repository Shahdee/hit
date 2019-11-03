using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LevelHelper 
{
    public static void GetNextCellCoords(ref int posX, ref int posY, Orientation toOrientation){

         switch(toOrientation){
            case Orientation.North:
                posY += 1;
            break;

            case Orientation.South:
                posY -=1;
            break;

            case Orientation.West:
                posX -= 1;
            break;

            case Orientation.East:
                posX += 1;
            break;
        }
    }

    public static void OrientationToDirection(out int dirX, out int dirY, Orientation toOrientation){

        dirX = 0;
        dirY = 0;

        switch(toOrientation){
            case Orientation.North:
                dirY = 1;
            break;

            case Orientation.South:
                dirY =-1;
            break;

            case Orientation.West:
                dirX =-1;
            break;

            case Orientation.East:
                dirX = 1;
            break;
        }
    }
}
