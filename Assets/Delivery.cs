using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float destroyDelay = 0.1f;
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Bump");

    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackage){
            Debug.Log("Package Picked");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.tag == "Customer" && hasPackage){
            Debug.Log("Package Delivered");
            hasPackage = false;
        }
    }
}
