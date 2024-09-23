using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PipeMoveScript : MonoBehaviour
{

    public float PipeSpeed = 5.0f;
    public float DeadZone = -45.0f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = transform.position + Vector3.left * PipeSpeed * Time.deltaTime;

        if (transform.position.x < DeadZone)
        {
            Debug.Log("Pipe Deleted!");
            Destroy(gameObject);
        }
    }
}
