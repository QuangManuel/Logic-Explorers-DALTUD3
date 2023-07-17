using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SplitColors : MonoBehaviour
{
    public static void SplitColorList(List<MyObject> objects)
    {
        List<MyObject> objWithColor1 = new List<MyObject>();
        List<MyObject> objWithColor2 = new List<MyObject>();
        List<MyObject> objWithColor3 = new List<MyObject>();

        foreach (MyObject obj in objects)
        {
            if (obj.Color == 1)
            {
                objWithColor1.Add(obj);
            }
            else if (obj.Color == 2)
            {
                objWithColor2.Add(obj);
            }
            else if (obj.Color == 3)
            {
                objWithColor3.Add(obj);
            }
        }

        Debug.Log("List of objects with color 1:");
        foreach (MyObject obj in objWithColor1)
        {
            Debug.Log(obj.GetInfo());
        }

        Debug.Log("List of objects with color 2:");
        foreach (MyObject obj in objWithColor2)
        {
            Debug.Log(obj.GetInfo());
        }

        Debug.Log("List of objects with color 3:");
        foreach (MyObject obj in objWithColor3)
        {
            Debug.Log(obj.GetInfo());
        }
    }
}
