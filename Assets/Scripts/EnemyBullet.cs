using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float bulletSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * bulletSpeed * Time.deltaTime);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Border"))
        {
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Barricade"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
