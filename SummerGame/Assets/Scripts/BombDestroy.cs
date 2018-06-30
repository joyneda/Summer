using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class BombDestroy : MonoBehaviour
{
    public GameObject explosion;
    Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("zangeki"))
        {
            Destroy(gameObject);
            Instantiate(explosion, this.transform.position, Quaternion.identity);
        }
    }
}