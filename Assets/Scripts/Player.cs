using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalAxis * Time.deltaTime * moveSpeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Enemy1") 
            || collision.collider.gameObject.CompareTag("Enemy2") 
            || collision.collider.gameObject.CompareTag("Enemy3") 
            || collision.collider.gameObject.CompareTag("Enemy4"))
        {
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
