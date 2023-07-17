using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitShapes : MonoBehaviour
{
    public static void SplitShapesList(List<MyObject> objects)
    {
        List<MyObject> objWithShape1 = new List<MyObject>();
        List<MyObject> objWithShape2 = new List<MyObject>();
        List<MyObject> objWithShape3 = new List<MyObject>();

        foreach (MyObject obj in objects)
        {
            if (obj.Shape == 1)
            {
                objWithShape1.Add(obj);
            }
            else if (obj.Shape == 2)
            {
                objWithShape2.Add(obj);
            }
            else if (obj.Shape == 3)
            {
                objWithShape3.Add(obj);
            }
        }

        Debug.Log("List of objects with shape 1:");
        foreach (MyObject obj in objWithShape1)
        {
            Debug.Log(obj.GetInfo());
        }

        Debug.Log("List of objects with shape 2:");
        foreach (MyObject obj in objWithShape2)
        {
            Debug.Log(obj.GetInfo());
        }

        Debug.Log("List of objects with shape 3:");
        foreach (MyObject obj in objWithShape3)
        {
            Debug.Log(obj.GetInfo());
        }
    }
}
