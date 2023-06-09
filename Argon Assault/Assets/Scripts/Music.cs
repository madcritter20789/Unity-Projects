using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
   void Awake() 
   {
        int numMusic = FindObjectsOfType<Music>().Length;
        if(numMusic > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
   }
}
