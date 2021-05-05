using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour

    
{
    public GameObject lastHit;
    public Vector3 collision = Vector3.zero;
    public LayerMask layer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var ray = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
            lastHit = hit.transform.gameObject;
            collision = hit.point;
        }
    }

     void OnDrawGizmos()
    {
        Update();
        Gizmos.color = Color.black;
        Gizmos.DrawWireSphere(collision, 1f);
    }
}
