using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    private bool inTrigger;
    // Use this for initialization
    void Start()
    {
        inTrigger = false;
    }

    // Update is called once per frame
    void Update () {
        if (inTrigger)
        {
            if (Input.GetButtonDown("Action"))
            {
                // Only specifying the sceneName or sceneBuildIndex will load the scene with the Single mode
                SceneManager.LoadScene("B1-SwitchCam");
            }
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            inTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            inTrigger = false;
        }
    }


}
