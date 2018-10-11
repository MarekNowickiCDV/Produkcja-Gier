using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scheduler : MonoBehaviour
{

    public static Scheduler Instance { get; private set; }

    void Awake()
    {
            Instance = this;
        
    }

    public void Schedule (float delay, Action action)
    {
        var coro = RunDelay(delay, action);
        StartCoroutine(coro);
    }

    IEnumerator RunDelay(float delay, Action action)
    {
        yield return new WaitForSeconds(delay);
        action();
    }
}
