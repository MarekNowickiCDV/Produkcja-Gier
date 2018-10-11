using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenager : MonoBehaviour
{
    public float Delay = 5;
    private void Start()
    {
        Action a = () =>
        {
            Debug.Log("Yo");
        };

        Scheduler.Instance.Schedule(Delay, a);
        
    }
}
