using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    int score;
    TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        scoreText.text = "Start";
    }
    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease;
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
