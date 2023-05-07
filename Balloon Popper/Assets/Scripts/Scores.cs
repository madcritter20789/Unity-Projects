using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    public Text myscore;
    public Touch script;
    
    // Start is called before the first frame update
    void Start()
    {
        myscore.text = "Score :" + script.totalScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
