using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitBalance : MonoBehaviour
{
    public static void SplitBalanceList(List<MyObject> objects)
    {
        int n = objects.Count;
        List<MyObject> halfObjectsOne = new List<MyObject>();
        List<MyObject> halfObjectsTwo = new List<MyObject>();

        for (int i = 0; i < n; i++)
        {
            if (i < n / 2)
            {
                halfObjectsOne.Add(objects[i]);
            }
            else
            {
                halfObjectsTwo.Add(objects[i]);
            }
        }

        Debug.Log("List of first half of objects:");
        foreach (MyObject obj in halfObjectsOne)
        {
            Debug.Log(obj.GetInfo());
        }

        Debug.Log("List of second half of objects:");
        foreach (MyObject obj in halfObjectsTwo)
        {
            Debug.Log(obj.GetInfo());
        }
    }
}
