using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityManager : MonoBehaviour, IInitable
{
    // instantiate objects  

    MainLogic m_Logic;

    public void Init(MainLogic logic){
        m_Logic = logic;
    }

    public Object CreateEntity(Object.ObjectType type){

        // Debug.Log("CreateEntity " + type);

        switch(type){

            case Object.ObjectType.Wall:
                return new Wall();

            case Object.ObjectType.Floor:
                return new Floor();

            case Object.ObjectType.Carpet:
                return new Carpet();

            case Object.ObjectType.Bed:
                return new Bed();

            case Object.ObjectType.Door:
                return new Door();

            case Object.ObjectType.Wardrobe:
                return new Wardrobe();

            case Object.ObjectType.Table:
                return new Table();

            default: return null;
        }
    }
}
