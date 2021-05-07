using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathOnimpact : MonoBehaviour
{
    public Transform Player;
    public Vector3 playerPos;
    private Vector3 restartPos;

   
    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player.transform.localPosition = playerPos;
        }
    }
}