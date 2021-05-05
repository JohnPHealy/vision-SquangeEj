using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDisable : MonoBehaviour
{
    public GameObject PlayerCamera;
    // Start is called before the first frame update
    void Start()
    {

    }
    [SerializeField]
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {


            PlayerCamera.SetActive(false);



        }
        //This is on entering in the player script, the exiting is on the cars script.

        // the CarComp is the script that gets enabled and along with the cameras attached to it. This is the script from above.

        if (Input.GetKeyUp(KeyCode.E))
        {

            // gameObject.enabled = true;

            PlayerCamera.SetActive(true);

        }
    }
}