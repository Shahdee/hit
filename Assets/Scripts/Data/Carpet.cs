using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carpet : Object
{
    public override bool isTraversable(){
        return true;
    }

    public override ObjectType GetObjType(){
       return ObjectType.Carpet;
   }
}
