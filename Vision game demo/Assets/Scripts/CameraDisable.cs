using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDisable : MonoBehaviour
{
    public GameObject intro;
    public GameObject PlayerCamera;
    // Start is called before the first frame update

    private GameObject[] RedCubes;
    private GameObject[] BlueCubes;
    private int i =0;
    void Start()
    {

    }





    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "intro")
        {

            i++;
            if (i == 300)
            {
                FindObjectOfType<AudioManager>().Play("intro");
                i = 0;
                Destroy(col.gameObject);
            }

        }
        if (col.gameObject.tag == "intro2")
        {

            i++;
            if (i == 300)
            {
                FindObjectOfType<AudioManager>().Play("intro2");
                i = 0;
                Destroy(col.gameObject);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {


            PlayerCamera.SetActive(true);


            RedCubes = GameObject.FindGameObjectsWithTag("Visible"); //get all RedCubes
            foreach (GameObject Visible in RedCubes) //access them individually 
            {
                Visible.GetComponent<BoxCollider>().enabled = true;

            }
            BlueCubes = GameObject.FindGameObjectsWithTag("InVisible");
            foreach (GameObject InVisible in BlueCubes) //access them individually 
            {
                InVisible.GetComponent<BoxCollider>().enabled = false;

            }



        }
        //This is on entering in the player script, the exiting is on the cars script.

        // the CarComp is the script that gets enabled and along with the cameras attached to it. This is the script from above.

       


        if (Input.GetKeyUp(KeyCode.E))
        {

            // gameObject.enabled = true;

            PlayerCamera.SetActive(false);


            RedCubes = GameObject.FindGameObjectsWithTag("Visible"); //get all RedCubes
            foreach (GameObject Visible in RedCubes) //access them individually 
            {
                Visible.GetComponent<BoxCollider>().enabled = false;

            }
            BlueCubes = GameObject.FindGameObjectsWithTag("InVisible");
            foreach (GameObject InVisible in BlueCubes) //access them individually 
            {
                InVisible.GetComponent<BoxCollider>().enabled = true;

            }

        }
    }
}