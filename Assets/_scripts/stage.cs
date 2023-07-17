using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour // Change 'stage' to 'Stage' here
{
    private string id;
    private string name;
    private bool[] challenges;
    private string[] fNid;
    private string[] rNid;

    // Create a class constructor for the stage class (this is just a test case)
    public Stage() // Change 'stage' to 'Stage' here
    {
        id = "lvl_01";
        name = "Level 1";
        challenges = new bool[] { true, true, true };
        fNid = new string[] { "f1", "f2", "f3" };
        rNid = new string[] { "r1", "r2", "r3" };
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Stage LVL02 = new Stage();
        LVL02.id = "lvl_02";
        LVL02.name = "Level 2";
        LVL02.challenges = new bool[] { true, true, true };
        LVL02.fNid = new string[] { "f1", "f2", "f3" };
        LVL02.rNid = new string[] { "r1", "r2", "r3" };
        Debug.Log(LVL02.id);
        Debug.Log(LVL02.name);
        foreach (bool i in LVL02.challenges)
        {
            Debug.Log(i);
        }
        foreach (string i in LVL02.fNid)
        {
            Debug.Log(i);
        }
        foreach (string i in LVL02.rNid)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
