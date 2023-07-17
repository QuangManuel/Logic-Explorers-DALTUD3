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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}