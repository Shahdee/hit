using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : Object
{
    public override bool isTraversable(){
        return true;
    }

    public override ObjectType GetObjType(){
       return ObjectType.Floor;
   }
}
