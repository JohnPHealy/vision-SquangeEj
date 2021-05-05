using UnityEngine;

public class IsVisible : MonoBehaviour
{

    float Visible;
    Renderer m_Renderer;
    // Use this for initialization
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Renderer.isVisible)
        {
            Visible = 1;
            //  Debug.Log("Object is visible");
            //   GetComponent<Collider>().enabled = false;
        }
        else //Debug.Log("Object is no longer visible");
            Visible = 0;
        
        if (Visible == 1)
        {
            GetComponent<Collider>().enabled = true;
        }
        if (Visible == 0)
        {
            GetComponent<Collider>().enabled = false;
        }
    } 
}