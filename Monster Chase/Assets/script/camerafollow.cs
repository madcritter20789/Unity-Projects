using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    
    private Transform player;

    private Vector3 tempos;

    [SerializeField]
    private float minX,maxX;
        void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {   
        if(!player)
            return;

        tempos = transform.position;
        tempos.x = player.position.x;
        
        if(tempos.x < minX)
            tempos.x = minX;
        
        if(tempos.x > maxX)
            tempos.x = maxX;

        transform.position = tempos;
    }
}
