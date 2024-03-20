using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IF_Statements : MonoBehaviour
{
    public int age;
    // Start is called before the first frame update
    void Start()
    {
        if (age > 18)
        {
            Debug.Log("You can vote");
        }
        else
        {
            Debug.Log("You can not vote");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
