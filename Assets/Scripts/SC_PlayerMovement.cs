using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_PlayerMovement : MonoBehaviour
{
    private Rigidbody RB;

    [SerializeField] private float forwardForce = 2000f;
    [SerializeField] private float sidewayForce = 500f;

    private void Awake()
    {
        RB = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        RB.AddForce(0,0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
            RB.AddForce(sidewayForce * Time.deltaTime, 0, 0);

        if (Input.GetKey("a"))
            RB.AddForce(-sidewayForce * Time.deltaTime, 0, 0);

    }
}
