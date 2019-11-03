using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundLogic : MonoBehaviour, IInitable, IUpdatable
{
    MainLogic m_Logic;
    
    public void Init(MainLogic logic)
    {
        m_Logic = logic;
    }

    public void UpdateMe(float delta)
    {
        
    }
}
