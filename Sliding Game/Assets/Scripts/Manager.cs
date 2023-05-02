using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    
    bool gameHasEnded = false;
    public float restartDelay = 2f;
    public GameObject completeLevelUI;


    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if(gameHasEnded==false)
        {
            gameHasEnded=true;
            Debug.Log("Game Over");
            Invoke("Restart",restartDelay);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
