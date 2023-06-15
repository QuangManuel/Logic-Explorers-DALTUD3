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
