using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppQuit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {   
            Debug.Log("you left the application");
            Application.Quit();
        }
    }
}
