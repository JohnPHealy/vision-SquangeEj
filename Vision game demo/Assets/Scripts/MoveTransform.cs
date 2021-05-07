using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTransform : MonoBehaviour
{
    int moving;
    private void OnCollisionEnter(Collision collision)
    {
        moving = 1;
    }
    // Update is called once per frame
    void Update()
    {   if (moving == 1)
        {
            transform.position += transform.forward * Time.deltaTime;
        }
    }
}
