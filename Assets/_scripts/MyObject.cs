using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyObject : MonoBehaviour
{
    // Khai báo thuộc tính
    public int Shape;
    public int Color;

    // Start is called before the first frame update
    void Start()
    {
        // Số lượng đối tượng muốn random
        int numObjects = Random.Range(1, 10);

        // Tạo List<MyObject> để lưu trữ các đối tượng MyObject được tạo ngẫu nhiên
        List<MyObject> objects = new List<MyObject>();

        // Tạo ngẫu nhiên các đối tượng và thêm vào List<MyObject>
        for (int i = 0; i < numObjects; i++)
        {
            MyObject obj = gameObject.AddComponent<MyObject>();
            obj.Shape = Random.Range(1, 4);
            obj.Color = Random.Range(1, 4);
            objects.Add(obj);
        }

        SplitColors.SplitColorList(objects);
        SplitShapes.SplitShapesList(objects);
        Trashcan.Trash(objects);
        SplitBalance.SplitBalanceList(objects);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Phương thức trả về thông tin đối tượng dưới dạng chuỗi
    public string GetInfo()
    {
        return "Shape: " + Shape + ", Color: " + Color;
    }
}
