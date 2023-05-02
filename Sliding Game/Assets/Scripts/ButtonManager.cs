using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
   
    public void exitgame()
    {   
        Debug.Log("Exit Button Pressed");
        Application.Quit();
    }
    public void changeScene()
    {
        SceneManager.LoadScene("Level01");
    }
}
