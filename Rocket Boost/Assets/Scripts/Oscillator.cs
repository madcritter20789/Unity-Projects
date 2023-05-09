using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    Vector3 startingPosition;
    [SerializeField] Vector3 movementVector;
    [SerializeField] [Range(0,1)] float movementFactor;
    [SerializeField] float period = 2f;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {   
        if(period<=Mathf.Epsilon)
        {
            return;
        }
        //continually growing over time
        float cycles = Time.time / period; 

        //constant value of 6.283
        const float tau =Mathf.PI*2;

        //going from -1 to 1
        float rawSinWave = Mathf.Sin(cycles*tau);

        //recalculated to go from -1 to 1
        movementFactor = (rawSinWave + 1f)/2f;

        Vector3 offSet = movementVector*movementFactor;
        transform.position = startingPosition + offSet;
    }
}
