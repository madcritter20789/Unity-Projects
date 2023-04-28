using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundScript : MonoBehaviour
{
   private void OnTriggerEnter()
   {
    SceneManager.LoadScene("SampleScene");
   }
}
