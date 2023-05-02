using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{

    public Manager gameManager;
    void OnTriggerEnter() 
    {
        gameManager.CompleteLevel();
    }
}
