 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bubblespawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] bubblesprefab;

    [SerializeField]
    float timebtwspawn = 0.2f;

    [SerializeField]
    float minTras;

    [SerializeField]
    float maxTras;

    void Start()
    {
        StartCoroutine(bubblesSpawn());
    }


    IEnumerator bubblesSpawn()
    {
        while(true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(bubblesprefab[Random.Range(0,bubblesprefab.Length)],position, Quaternion.identity);
            yield return new WaitForSeconds(timebtwspawn);
            
            Destroy(gameObject, 10f);
        }


    }
   
}



/*public GameObject[] meteors;
//int meteorNo;
public float maxPos = 2.4f;
public float delayTimer = 1.25f;
public float timeNeed = 10f;
public float time = 0f;
float timer;

// Use this for initialization
void Start()
{
    timer = delayTimer;

}

// Update is called once per frame
void Update()
{

    timer -= Time.deltaTime;
    if (timer <= 0)
    {
        Vector3 meteorPos = new Vector3(Random.Range(-2.2f, 2.2f), transform.position.y, transform.position.z);
        //meteorNo = Random.Range(0, 2);
        Instantiate(meteors[0], meteorPos, transform.rotation);
        timer = delayTimer;
    }
    time += Time.deltaTime;
    if (time => timeNeed)
    {
        Vector3 meteorPos = new Vector3(Random.Range(-2.2f, 2.2f), transform.position.y, transform.position.z);
        //meteorNo = Random.Range(0, 2);
        Instantiate(meteors[1], meteorPos, transform.rotation);
    }


}*/

