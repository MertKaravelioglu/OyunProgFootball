using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public player1 player1;
    public player2 player2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player1.transform.position=new Vector3 (0f, 1.65f, 5.95f);
        player2.transform.position = new Vector3(0f, 1.65f, -6.23f);
    }
}
