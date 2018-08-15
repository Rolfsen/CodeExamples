using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



[RequireComponent(typeof(Stats))]

public class Character : MonoBehaviour
{
    
    private Stats stats = new Stats(5,2,1,5,6);

    void DoSomething()
    {
        var a = stats.Strenght + 4;

        print(a);

        print(stats.ChangeState(a, 3));

    }

}
