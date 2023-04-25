using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    MeshRenderer rendrer; 
    Rigidbody rb;
    [SerializeField] float timer=3f;
    // Start is called before the first frame update
    void Start()
    {
        rendrer = GetComponent<MeshRenderer>();
        rendrer.enabled = false;
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>timer)
        {
            rendrer.enabled = true;
            rb.useGravity = true;
        }
    }
}
