using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCubes : MonoBehaviour
{
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            rb.isKinematic = false;
            Destroy(gameObject, 2);
        }
    }


}
