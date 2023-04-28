using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
   public void restartGame()
   {
    SceneManager.LoadScene("SampleScene");
   }

    public void exitGame()
    {   
        Debug.Log("Exit Button Pressed");
        Application.Quit();
    }

}
