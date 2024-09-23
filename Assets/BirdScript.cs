using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public float flapStrength;
    void Start()
    {
        gameObject.name = "Elena";
    }

    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Space))
            myRigidBody.velocity = Vector2.up * flapStrength;
    }
}
