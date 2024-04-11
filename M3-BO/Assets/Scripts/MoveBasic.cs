using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBasic : MonoBehaviour
{
    public float speed = 50f;
    public float rotSpeed = 50f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //Debug.Log("w");
            rb.AddForce(transform.forward * speed * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            rb.velocity = Vector3.zero;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            rb.velocity = Vector3.zero;
        }
        float xMove = Input.GetAxis("Horizontal");

        rb.transform.Rotate(transform.up, rotSpeed * xMove * Time.deltaTime);
        
        //Vector3 positionUpdate = transform.position + Input.GetAxis("Vertical") * transform.forward * speed * Time.deltaTime;
        //transform.position = positionUpdate;
        //transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0));
    }
}
