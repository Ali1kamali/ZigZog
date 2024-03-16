using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Ball : MonoBehaviour
{
    [Range(2f, 20f)]
    public float speed;
    public bool isRight = true;


    Vector3 GoRun = new Vector3 (1, 0, 0);
    Vector3 GoLeft = new Vector3 (0, 0, 1);
    Vector3 GoRight = new Vector3 (1, 0, 0);


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -3)
        {
            
        }

        Move();
        transform.position += GoRun * speed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Dimond")
        {
            Destroy(other.gameObject);
        }
    }

    private void Move()
    {
        if (isRight)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GoRun = GoLeft;
                isRight = false;
            }
        }
        else
        {
            if (Input.GetMouseButtonDown (0))
            {
                GoRun = GoRight;
                isRight = true;
            }
        }
    }
}
