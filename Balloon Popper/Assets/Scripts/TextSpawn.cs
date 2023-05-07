using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSpawn : MonoBehaviour
{
    public GameObject[] textspawnner;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(textS());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator textS()
    {
        while (true)
        {
            GameObject gameObject = Instantiate(textspawnner[Random.Range(0, textspawnner.Length)], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(5f);

            Destroy(gameObject, 40f);
        }


    }
}
