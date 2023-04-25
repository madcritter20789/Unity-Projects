using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score = 5;
    public int hit = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) 
    {    
        if(other.gameObject.tag!="Hit")  
        {
            hit++;
            Debug.Log("You hit the wall this many times "+ hit); 
        }       
    }
}
