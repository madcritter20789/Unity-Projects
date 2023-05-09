using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    [SerializeField] float mainThrust = 10f;
    [SerializeField] float rotationThrust = 10f;
    [SerializeField] AudioClip mEngine;
    [SerializeField] ParticleSystem mainEngineParticle;
    [SerializeField] ParticleSystem leftEngineParticle;
    [SerializeField] ParticleSystem rightEngineParticle;    
    
   
    public Rigidbody rb;
    public AudioSource sourceAudio;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
        sourceAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotate();
    }

    public void ProcessThrust()
    {
        if(Input.GetKey(KeyCode.Space))
        {   //Giving an upward force 
            StartThrust();
        }
        else
        {
            StopThrust();
        }
    }
    public void ProcessRotate()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            //Rotating in left side
            LeftRotate();
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            //Rotating right side
            RightRotate();
        }
        else
        {
            StopRotate();
        }
    }

    private void StopThrust()
    {
        sourceAudio.Stop();
        mainEngineParticle.Stop();
    }

    private void StartThrust()
    {
        rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        if (!sourceAudio.isPlaying)
        {
            sourceAudio.PlayOneShot(mEngine);
        }
        if (!mainEngineParticle.isPlaying)
        {
            mainEngineParticle.Play();
        }
    }

    private void StopRotate()
    {
        leftEngineParticle.Stop();
        rightEngineParticle.Stop();
    }

    private void RightRotate()
    {
        Rotation(-rotationThrust);
        if (!rightEngineParticle.isPlaying)
        {
            rightEngineParticle.Play();
        }
    }

    private void LeftRotate()
    {
        Rotation(rotationThrust);
        if (!leftEngineParticle.isPlaying)
        {
            leftEngineParticle.Play();
        }
    }

    public void Rotation(float rotationThisFrame)
    {   //freezeing the rotation
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        //unfreezing the rotation so the physics can take over
        rb.freezeRotation = false;
    }
}
