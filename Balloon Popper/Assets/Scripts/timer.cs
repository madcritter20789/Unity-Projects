using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float Timevalue = 60;
    public Text timertxt;
    public GameObject panels;
    public GameObject time;
    public GameObject panelgames;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timevalue -= Time.deltaTime;
        timertxt.text = Timevalue.ToString("00");

        if(Timevalue<=0)
        {
            panels.SetActive(true);
            panelgames.SetActive(true);
            time.SetActive(false);
           
        }
    }
}
