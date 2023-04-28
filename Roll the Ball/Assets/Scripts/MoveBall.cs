using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveBall : MonoBehaviour
{
    Rigidbody rb;
    public int ballSpeed=0;
    public int jumpSpeed=0;
    public bool isTouching = true;
    private int counter ;
    public Text cointext;
    public AudioSource asource;
    public AudioClip aclip;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        counter = 17;
        cointext.text = "Coins: " + counter;
    }

    // Update is called once per frame
    void Update()
    {
        float Hmove = Input.GetAxis("Horizontal");
        float Vmove = Input.GetAxis("Vertical");

        Vector3 ballMove = new Vector3 (Hmove, 0.0f, Vmove);

        rb.AddForce(ballMove*ballSpeed);

        if(Input.GetKey(KeyCode.Space) && isTouching==true)
        {
            Vector3 ballJump = new Vector3(0.0f,5.0f,0.0f);
            rb.AddForce(ballJump*jumpSpeed);
            
        }
        isTouching=false;
        
    }
    
    private void OnCollisionStay(Collision other) 
    {
        isTouching=true;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag ("Coin"))
        {
            other.gameObject.SetActive(false);
            counter = counter - 1;
            cointext.text = "Coins: " + counter;
            asource.PlayOneShot(aclip);
        }
        if(counter==0)
        {
            SceneManager.LoadScene("EndScene");
        }
        
    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
    if(collision.gameObject.tag == "Ground")
    {
        isTouching=true;
    }   
    }*/

}
