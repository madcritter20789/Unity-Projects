using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float startTime = 5f;
    public float currentTime;
    [SerializeField]
    private Text countdown;
    public GameObject countText;
    public GameObject Timers;
    public GameObject spawnner;
   



    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdown.text = currentTime.ToString("0");
        if(currentTime<0)
        {   
            spawnner.SetActive(true);
            Timers.SetActive(true);          
            countText.SetActive(false);
           
        }
    }
}
