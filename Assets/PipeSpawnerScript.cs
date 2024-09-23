using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{

    public GameObject Pipe;
    public float SpawnRate = 2.0f;
    private float Timer = 0.0f;
    public float HeightOffset = 10;
    void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
        Timer += Time.deltaTime;
        if(Timer > SpawnRate)
        {
            SpawnPipe();
            Timer -= SpawnRate;
        }
    }

    private void SpawnPipe()
    {
        float lowestPoint = transform.position.y - HeightOffset;
        float highestPoint = transform.position.y + HeightOffset;

        Instantiate(Pipe, new Vector3(transform.position.x,
            Random.Range(lowestPoint, highestPoint), 
            transform.position.z), transform.rotation);
    }
}
