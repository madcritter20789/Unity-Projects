using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collisions : MonoBehaviour
{
    [SerializeField] float delayTime = 2f;
     [SerializeField] AudioClip mCollide;
    [SerializeField] AudioClip mSuccess;
    [SerializeField] ParticleSystem successParticles;
    [SerializeField] ParticleSystem crashParticles;
    public AudioSource sourceAudio;
    bool isTransitioning = false;
    // Start is called before the first frame update
    void Start()
    {
        sourceAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        RespondToKeys();
    }

    void RespondToKeys()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            StartNextLevel();
        }
    }
    void OnCollisionEnter(Collision other) 
    {
        if(!isTransitioning)
        { 
        switch(other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("Friendly");
                break;
            case "Finish":
                StartNextLevel();    
                break;
            default:
                StartCrash();
                break;
        } 
        }
          
    }

    void StartCrash()
    {
        isTransitioning = true;
        crashParticles.Play();
        GetComponent<Movements>().enabled = false;
        Invoke("ReloadLevel",delayTime);
        if(!sourceAudio.isPlaying)
            {
                sourceAudio.PlayOneShot(mCollide);
            }
    }
    void StartNextLevel()
    {
        isTransitioning = true;
        successParticles.Play();
        GetComponent<Movements>().enabled = false;
        Invoke("nextLevel",delayTime);
        if(!sourceAudio.isPlaying)
            {
                sourceAudio.PlayOneShot(mSuccess);
            }
    }

    public void ReloadLevel()
    {   int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
    public void nextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextScene = currentSceneIndex + 1;
        if(nextScene == SceneManager.sceneCountInBuildSettings)
        {
            nextScene = 0;
        }
        SceneManager.LoadScene(nextScene);
    }
}
