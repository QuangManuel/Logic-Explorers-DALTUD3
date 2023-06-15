using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public string ID; // Mã định danh cho pipe
    public FunctionNode node; // Node bắt đầu của pipe
    // Hàm khởi tạo pipe với ID và node bắt đầu/kết thúc tương ứng
    public Pipe(string id, FunctionNode start) {
        ID = id;
        node = start;
    }
    public static void Main(string[] args) {
        // Tạo một đối tượng FunctionNode mới
        Pipe myPipe = new Pipe("001", node);

        // Lấy thông tin thuộc tính và in ra màn hình
        Console.WriteLine("ID: " + myPipe.GetPipeID());
        Console.WriteLine("Start: " + myPipe.GetNode().name);
    }
    // Hàm lấy ID của pipe
    public string GetPipeID() {
        return ID;
    }
    // Hàm lấy node bắt đầu của pipe
    public FunctionNode GetNode() {
        return node;
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
