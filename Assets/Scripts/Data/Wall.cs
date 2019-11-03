using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : Object
{
    public override ObjectType GetObjType(){
       return ObjectType.Wall;
   }
}
