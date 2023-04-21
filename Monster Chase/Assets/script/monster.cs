using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour
{
    [HideInInspector]
    public float speed;
    private Rigidbody2D myBody;
    void Awake() 
    {
      myBody = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
       myBody.velocity = new Vector2(speed, myBody.velocity.y); 
    }
}
