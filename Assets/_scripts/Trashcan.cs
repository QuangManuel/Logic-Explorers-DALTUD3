using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trashcan : MonoBehaviour
{
    public static void Trash(List<MyObject> objects)
    {
        List<MyObject> trash = new List<MyObject>();

        foreach (MyObject obj in objects)
        {
            // Xóa các đối tượng không cần thiết
            trash.Add(obj);
        }

        // Xóa các đối tượng trong List<MyObject> không cần thiết và in ra thông báo
        Debug.Log("Trashed objects:");
        foreach (MyObject obj in trash)
        {
            Debug.Log(obj.GetInfo());
        }
        objects.RemoveAll(obj => trash.Contains(obj));
    }
}
