using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public Rigidbody myRigidBody;

    private void Start()
    {
        myRigidBody.AddForce(0.0f, 500.0f, 0.0f);
    }
}
