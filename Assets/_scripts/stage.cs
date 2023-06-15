using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage : MonoBehaviour
{
    private string id;
    private string name;
    private bool[] challenges;
    private string[] fNid;
    private string[] rNid;


    // Create a class constructor for the stage class (this is just a test case)
    public stage()
    {
        id = "lvl_01"; // Set the initial value for model
        name = "Level 1";
        challenges = [true, true, true];
        fNid = ["f1","f2","f3"];
        rNid = ["r1","r2","r3"];
    }

    static void Main(string[] args)
    {
        Stage LVL02 = new Stage();
        LVL02.id = "lvl_02";
        LVL02.name = "Level 2";
        LVL02.challenges = new bool[] { true, true, true }; // Create a new array object
        LVL02.fNid = new string[] { "f1", "f2", "f3" }; // Create a new array object
        LVL02.rNid = new string[] { "r1", "r2", "r3" }; // Create a new array object
        Console.WriteLine(LVL02.id);
        Console.WriteLine(LVL02.name);
        foreach (bool i in LVL02.challenges)
        {
            Console.Write(i);
        }
        foreach (string i in LVL02.fNid)
        {
            Console.Write(i);
        }
        foreach (string i in LVL02.rNid)
        {
            Console.Write(i);
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
