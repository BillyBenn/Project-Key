using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;
    public int time;
    public int objSpeed = 3;
    public int xToMove = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.localPosition += new Vector3(objSpeed, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKey("d"))
        {
            transform.localPosition += new Vector3(-objSpeed, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKey("w"))
        {
            transform.localPosition += new Vector3(0, 0, -objSpeed) * Time.deltaTime;
        }

        if (Input.GetKey("s"))
        {
            transform.localPosition += new Vector3(0, 0, objSpeed) * Time.deltaTime;
        }
    }
}
