using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject enemyVFX;
    // [SerializeField] GameObject hitVFX;
    [SerializeField] int ScorePerHit = 10;
    [SerializeField] int hitPoints = 2;

    Score scoreBoard;
    
    GameObject parentGameobject;

    void Start()
    {
        scoreBoard =FindObjectOfType<Score>();
        parentGameobject = GameObject.FindWithTag("SpawnAtRunTime");
        Rigidbody rb = gameObject.AddComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void OnParticleCollision(GameObject other)
    {
        HitProcess();
        if(hitPoints<0)
        {
        EnemyKill();
        }
    }

    void HitProcess()
    {
        // GameObject vfx = Instantiate(hitVFX, transform.position, Quaternion.identity);
        //vfx.transform.parent = parent.transform;
        hitPoints--;
        scoreBoard.IncreaseScore(ScorePerHit);
    }
     void EnemyKill()
    {
        GameObject vfx = Instantiate(enemyVFX, transform.position, Quaternion.identity);
        vfx.transform.parent = parentGameobject.transform;
        Destroy(gameObject);
    }
}
