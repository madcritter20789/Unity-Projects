using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("General control settings")]
    [SerializeField] float speedController = 10f;
    [Tooltip("Screen restrictions for player movement")]
    [SerializeField] float xRange = 5f;
    [Tooltip("Screen restrictions for player movement")]
    [SerializeField] float yRange = 5f;

    [Header("Laser guns array")]
    [SerializeField] GameObject[] lasers;

    [Header("Screen position of plane tuning")]

    [SerializeField] float positionPitchFactor = -2f;
    [Header("Player input based tuning")]
    [SerializeField] float positionYawFactor = 2f;
    [SerializeField] float controlPitchFactor = -10f;
    
    [SerializeField] float controlRollFactor = -20f;
     float xThrow, yThrow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ControlMove();
        ControlRotation();
        ControlFiring();
    }

    void ControlRotation()
    {
        float pitchPostion = transform.localPosition.y*positionPitchFactor;
        float pitchControl = yThrow*controlPitchFactor;
        
        float yawPostion = transform.localPosition.x*positionYawFactor;
        float rollControl = xThrow*controlRollFactor;

        float pitch = pitchPostion + pitchControl;
        float yaw = yawPostion;
        float roll = rollControl;
        transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
    }

    void ControlMove()
    {
        xThrow = Input.GetAxis("Horizontal");

        yThrow = Input.GetAxis("Vertical");

        float xOffset = xThrow * Time.deltaTime * speedController;
        float rawXpos = transform.localPosition.x + xOffset;
        float clampedXPos = Mathf.Clamp(rawXpos, -xRange, xRange);

        float yOffset = yThrow * Time.deltaTime * speedController;
        float rawYpos = transform.localPosition.y + yOffset;
        float clampedYPos = Mathf.Clamp(rawYpos, -yRange, yRange);

        transform.localPosition = new Vector3(clampedXPos, clampedYPos, transform.localPosition.z);
    }

    void ControlFiring()
    {
        // If pushing fire button
        if(Input.GetButton("Fire1"))
        {
            SetLaserActive(true);
        }
        else
        {
            SetLaserActive(false);
        } 
    }

    void SetLaserActive(bool isActive)
    {
        foreach(GameObject laser in lasers)
        {
            var emmissionModule = laser.GetComponent<ParticleSystem>().emission;
            emmissionModule.enabled = isActive;
        }
    }


}
