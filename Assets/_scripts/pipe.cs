using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public string ID; // Mã định danh cho pipe
    public Node node; // Node bắt đầu của pipe
    // Hàm khởi tạo pipe với ID và node bắt đầu/kết thúc tương ứng
    public Pipe(string id, Node start) {
        ID = id;
        node = start;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        // Tạo một đối tượng Node mới với các đối số cần thiết
        Node start = new Node("001", "Start Node", 0, "Start Address");

        // Tạo một đối tượng Pipe mới với ID và node bắt đầu đã khởi tạo
        Pipe myPipe = new Pipe("001", start);

        // Lấy thông tin thuộc tính và in ra màn hình
        Debug.Log("ID: " + myPipe.GetPipeID());
        Debug.Log("Start: " + myPipe.GetNode().name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Hàm lấy ID của pipe
    public string GetPipeID() {
        return ID;
    }
    // Hàm lấy node bắt đầu của pipe
    public Node GetNode() {
        return node;
    }
}
