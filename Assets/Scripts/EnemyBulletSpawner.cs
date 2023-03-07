using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletSpawner : MonoBehaviour
{
    public GameObject enemyBulletPrefab;
    public float bulletTimer;

    public float timerMax = 10;
    public float timerMin = 5;
    // Start is called before the first frame update
    void Start()
    {
        bulletTimer = Random.Range(timerMin, timerMax);
    }

    // Update is called once per frame
    void Update()
    {
        bulletTimer -= Time.deltaTime;
        if (bulletTimer <= 0)
        {
            Instantiate(enemyBulletPrefab, transform.position, Quaternion.identity);
            bulletTimer = Random.Range(timerMin, timerMax);
        }
        
    }
}
