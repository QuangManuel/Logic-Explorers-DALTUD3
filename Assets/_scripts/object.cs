using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    // Khai báo thuộc tính
    public int Shape;
    public int Color;
    // Các phương thức khởi tạo
    public Object() {
        // Tạo instance của class Random
        Random random = new Random();

        // Random thuộc tính Shape trong khoảng từ 1 đến 3
        Shape = random.Next(1, 4);

        // Random thuộc tính Color trong khoảng từ 1 đến 3
        Color = random.Next(1, 4);
    }
  
    // Phương thức trả về thông tin đối tượng dưới dạng chuỗi
    public string GetInfo() 
    {
        return "Shape: " + Shape + ", Color: " + Color;
    }

    public static void Main(string[] args) {
    	// Tạo một đối tượng FunctionNode mới
        Node node = new Node("ID001", "functionNode", 2, "avatar.png");
        
        // Số lượng đối tượng muốn random
        int numObjects = new Random().Next(1, 10);

        // Tạo List<Object> để store numberObjects của đối tượng Object được tạo ngẫu nhiên
        List<Object> objects = new List<Object>();

        // Tạo ngẫu nhiên các đối tượng và thêm vào List<Object>
        for (int i = 0; i < numObjects; i++) 
        {
            Object obj = new Object();
            objects.Add(obj);
        }
        
    	SplitColors.SplitColorList(objects);
        SplitShapes.SplitShapesList(objects);
        Trashcan.Trash(objects);
        SplitBalance.SplitBalanceList(objects);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
