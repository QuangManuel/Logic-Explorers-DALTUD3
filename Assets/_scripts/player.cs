using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public string name;
    public int score;

    // Create a class constructor for the Player class (this is just a test case)
    public player()
    {
        name = "Quang"; // Set the initial value for model
        score = 200;
    }

    // Start is called before the first frame update
    void Start()
    {
        player user1 = new player();
        user1.name = "Thien";
        user1.score = 500;
        Debug.Log(user1.name);
        Debug.Log(user1.score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
