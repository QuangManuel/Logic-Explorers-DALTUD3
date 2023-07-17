using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour {
    // Khai báo thuộc tính
    public string ID;
    public string Name;
    public int IMatches;
    public string Avatar;
    // Các phương thức khởi tạo
    public Node(string id, string name, int iMatches, string avatar) {
        ID = id;
        Name = name;
        IMatches = iMatches;
        Avatar = avatar;
    }
    public static void Main(string[] args) {
        // Tạo một đối tượng FunctionNode mới
        Node node = new Node("ID001", "functionNode", 2, "avatar.png");

        // Lấy thông tin thuộc tính và in ra màn hình
        Console.WriteLine("ID: " + node.ID);
        Console.WriteLine("Name: " + node.Name);
        Console.WriteLine("IMatches: " + node.IMatches);
        Console.WriteLine("Avatar: " + node.Avatar);
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

public class SplitColors : Node {
    public SplitColors(string id, string name, int iMatches, string avatar) : base(id, name, iMatches, avatar){
        
    }

    public static void SplitColorList(List<Object> objects)
    {
        List<Object> objWithColor1 = new List<Object>();
        List<Object> objWithColor2 = new List<Object>();
        List<Object> objWithColor3 = new List<Object>();
        

        foreach (Object obj in objects)
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

        Console.WriteLine("List of objects with color 1:");
        foreach (Object obj in objWithColor1)
        {
            Console.WriteLine(obj.GetInfo());
        }

        Console.WriteLine("List of objects with color 2:");
        foreach (Object obj in objWithColor2)
        {
            Console.WriteLine(obj.GetInfo());
        }
        
        Console.WriteLine("List of objects with color 3:");
        foreach (Object obj in objWithColor3)
        {
            Console.WriteLine(obj.GetInfo());
        }
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

public class SplitShapes : Node {
    public SplitShapes(string id, string name, int iMatches, string avatar) : base(id, name, iMatches, avatar){
        
    }

    public static void SplitShapesList(List<Object> objects)
    {
        List<Object> objWithShape1 = new List<Object>();
        List<Object> objWithShape2 = new List<Object>();
        List<Object> objWithShape3 = new List<Object>();
        

        foreach (Object obj in objects)
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

        Console.WriteLine("List of objects with shape 1:");
        foreach (Object obj in objWithShape1)
        {
            Console.WriteLine(obj.GetInfo());
        }

        Console.WriteLine("List of objects with shape 2:");
        foreach (Object obj in objWithShape2)
        {
            Console.WriteLine(obj.GetInfo());
        }
        
        Console.WriteLine("List of objects with shape 3:");
        foreach (Object obj in objWithShape3)
        {
            Console.WriteLine(obj.GetInfo());
        }
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

public class Trashcan : Node
{
    public Trashcan(string id, string name, int iMatches, string avatar) : base(id, name, iMatches, avatar) {
        
    }

    public static void Trash(List<Object> objects)
    {
        List<Object> trash = new List<Object>();

        foreach (Object obj in objects)
        {
            // Xóa các đối tượng không cần thiết
            trash.Add(obj);
        }

        // Xóa các đối tượng trong List<Object> không cần thiết và in ra thông báo
        Console.WriteLine("Trashed objects:");
        foreach (Object obj in trash)
        {
            Console.WriteLine(obj.GetInfo());
        }
        objects.RemoveAll(obj => trash.Contains(obj));
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

public class SplitBalance : Node
{
    public SplitBalance(string id, string name, int iMatches, string avatar) : base(id, name, iMatches, avatar){

    }

    public static void SplitBalanceList(List<Object> objects)
    {
        int n = objects.Count;
        List<Object> halfObjectsOne = new List<Object>();
        List<Object> halfObjectsTwo = new List<Object>();

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

        Console.WriteLine("List of first half of objects:");
        foreach (Object obj in halfObjectsOne)
        {
            Console.WriteLine(obj.GetInfo());
        }

        Console.WriteLine("List of second half of objects:");
        foreach (Object obj in halfObjectsTwo)
        {
            Console.WriteLine(obj.GetInfo());
        }
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