using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoRotation : MonoBehaviour
{
    [SerializeField] private float speed = 50f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 positionUpdate = transform.position + Input.GetAxis("Vertical") * transform.forward * speed * Time.deltaTime;
        transform.position = positionUpdate;
        Vector3 positionUpdateTwo = transform.position + Input.GetAxis("Horizontal") * transform.right * speed * Time.deltaTime;
        transform.position = positionUpdateTwo;
    }
}
