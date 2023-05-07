using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Touch : MonoBehaviour
{
    public float laserLength = 0.3f;
    public int totalScore = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D Ray = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.up * laserLength);

            Debug.DrawRay(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.up * laserLength, Color.red);



            if (Ray.collider != null)
            {
                if (Ray.collider.gameObject.CompareTag("BallonR"))
                {
                    totalScore++;
                    Debug.Log(totalScore);
                    Ray.collider.gameObject.GetComponent<Animator>().SetBool("Destroy", true);
                    Destroy(Ray.collider.gameObject, .4f);
                }
                if (Ray.collider.gameObject.CompareTag("BalloonB"))
                {
                    totalScore++;
                    Debug.Log(totalScore);
                    Ray.collider.gameObject.GetComponent<Animator>().SetBool("Destroy", true);
                    Destroy(Ray.collider.gameObject, .4f);
                }
                if (Ray.collider.gameObject.CompareTag("BalloonY"))
                {
                    totalScore++;
                    Debug.Log(totalScore);
                    Ray.collider.gameObject.GetComponent<Animator>().SetBool("Destroy", true);
                    Destroy(Ray.collider.gameObject, .4f);
                }
                if (Ray.collider.gameObject.CompareTag("BalloonO"))
                {
                    totalScore++;
                    Debug.Log(totalScore);
                    Ray.collider.gameObject.GetComponent<Animator>().SetBool("Destroy", true);
                    Destroy(Ray.collider.gameObject, .4f);
                }
                if (Ray.collider.gameObject.CompareTag("BalloonG"))
                {
                    totalScore++;
                    Debug.Log(totalScore);
                    Ray.collider.gameObject.GetComponent<Animator>().SetBool("Destroy", true);
                    Destroy(Ray.collider.gameObject, .4f);
                }
                if (Ray.collider.gameObject.CompareTag("BalloonI"))
                {
                    totalScore++;
                    Debug.Log(totalScore);
                    Ray.collider.gameObject.GetComponent<Animator>().SetBool("Destroy", true);
                    Destroy(Ray.collider.gameObject, .4f);
                }
                if (Ray.collider.gameObject.CompareTag("BalloonP"))
                {
                    totalScore++;
                    Debug.Log(totalScore);
                    Ray.collider.gameObject.GetComponent<Animator>().SetBool("Destroy", true);
                    Destroy(Ray.collider.gameObject, .4f);
                }


            }

        }      
        Debug.Log(totalScore); 
    }
};