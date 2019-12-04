using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddExplosionToPlayer : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(transform.TransformDirection(0,3,3));
        }
    }
}
