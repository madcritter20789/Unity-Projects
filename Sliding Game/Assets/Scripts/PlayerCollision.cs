using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovements movemments;

    void OnCollisionEnter(Collision collisionInfo) 
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movemments.enabled = false;
            FindObjectOfType<Manager>().EndGame();
        }   
    } 
    
}
