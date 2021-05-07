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
    private int i = 0;
    private int w = 0;
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

        if (col.gameObject.tag == "puzzle1fall")
        {

            i++;
            if (i == 1)
            {
                FindObjectOfType<AudioManager>().Play("puzzle1fall");
                i = 0;
                Destroy(col.gameObject);
            }

        }

        if (col.gameObject.tag == "puzzletime")
        {
            Debug.Log(w);
            w++;
            if (w == 1000)
            {

                w = Random.Range(0, 400);

                int n = Random.Range(1, 11);

                if (n == 1)
                {
                    FindObjectOfType<AudioManager>().Play("puzzlewait1");
                }
                if (n == 2)
                {
                    FindObjectOfType<AudioManager>().Play("puzzlewait2");
                }
                if (n == 3)
                {
                    FindObjectOfType<AudioManager>().Play("puzzlewait3");
                }
                if (n == 4)
                {
                    FindObjectOfType<AudioManager>().Play("puzzlewait4");
                }
                if (n == 5)
                {
                    FindObjectOfType<AudioManager>().Play("puzzlewait5");
                }
                if (n == 6)
                {
                    FindObjectOfType<AudioManager>().Play("puzzlewait6");
                }
                if (n == 7)
                {
                    FindObjectOfType<AudioManager>().Play("puzzlewait7");
                }
                if (n == 8)
                {
                    FindObjectOfType<AudioManager>().Play("puzzlewait8");
                }
                if (n == 9)
                {
                    FindObjectOfType<AudioManager>().Play("puzzlewait9");
                }
                if (n == 10)
                {
                    FindObjectOfType<AudioManager>().Play("puzzlewait10");
                }
                if (n == 11)
                {
                    FindObjectOfType<AudioManager>().Play("completema");
                }
            }

        }

        if (col.gameObject.tag == "level1start")
        {

            i++;
            if (i > 1)
            {
                FindObjectOfType<AudioManager>().Play("level1start");
                i = 0;
                Destroy(col.gameObject);
            }

        }
        if (col.gameObject.tag == "level2start")
        {

            i++;
            if (i > 1)
            {
                FindObjectOfType<AudioManager>().Play("level2start");
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