using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] float mainThrust = 100f;
    [SerializeField] float rightThrust = 100f;
    [SerializeField] float leftThrust = 100f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }


    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        }
    }
    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Pressed D -Rotate Right");
            transform.Rotate(Vector3.back * rightThrust * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Pressed A -Rotate Left");
            transform.Rotate(Vector3.forward * leftThrust * Time.deltaTime);
        }
    }
}