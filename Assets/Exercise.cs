using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise : MonoBehaviour
{
    int[] intArray = { 1, 3, 5, 7, 9 };

    void Start()
    {
        foo();
        oof();
    }

    void foo()
    {
        for (int i = 0; i < intArray.Length; i++)
        {
            Debug.Log(intArray[i]);
        }
    }

    void oof()
    {
        for (int i = intArray.Length - 1; i > -1; i--)
        {
            Debug.Log(intArray[i]);
        }
    }
}

