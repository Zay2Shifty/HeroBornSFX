using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBehavior : MonoBehaviour
{
    public float BoostMultiplier = 0.5f;
    public float BoostSeconds = 5.0f;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.transform.parent.gameObject);
        Debug.Log("OH NO!! UNABLE TO JUMP FOR 5 SECONDS");

        PlayerBehavior Player = collision.gameObject.GetComponent<PlayerBehavior>();
        Player.JumpBoost(BoostMultiplier, BoostSeconds);
    }
}