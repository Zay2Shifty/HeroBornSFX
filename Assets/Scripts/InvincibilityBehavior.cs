using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibilityBehavior : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(transform.parent.gameObject);
            Debug.Log("FEEL THE POWER OF A GOD!!");
        }
    }
}
