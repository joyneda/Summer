﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuikaController : MonoBehaviour
{

    private Rigidbody rb;
    public float direction;
    public float timeout;
    private float timeElapsed;

    public int scoreValue;
    private WatermelonController watermelonController;
    // Use this for initialization
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeAll;
        timeElapsed = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Space)){
        // Pakkan();
        //}
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= timeout)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("zangeki"))
        {
            Pakkan();
        }
    }
    void Pakkan()
    {
        rb.constraints = RigidbodyConstraints.None;
        rb.AddForce(new Vector3(direction, 2, 0), ForceMode.Impulse);
        rb.AddTorque(0, 0, -direction);
    }
    //private void OnTriggerEnter(Collider other)
  //  {
   //     watermelonController.AddScore(scoreValue);
   // }
}