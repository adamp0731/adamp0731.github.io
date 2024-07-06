using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SwapCamera : MonoBehaviour
{

    public Camera thirdPersonView;
    public Camera droneCam;
    public Canvas canvas;

    void Start()
    {
        GameObject tempCanvas = GameObject.Find("Canvas");
        canvas = tempCanvas.GetComponent<Canvas>();
        thirdPersonView = GameObject.FindWithTag("MainCamera").GetComponent<Camera>() as Camera;
        thirdPersonView.enabled = true;
        droneCam.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            canvas.gameObject.SetActive(false);
            thirdPersonView.enabled = !thirdPersonView.enabled;
            droneCam.enabled = !droneCam.enabled;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }

        Debug.Log((int)(1f / Time.unscaledDeltaTime) + " fps");
    }
}
