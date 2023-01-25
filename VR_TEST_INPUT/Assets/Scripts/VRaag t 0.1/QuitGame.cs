using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    [Header ("StopButton")]
    [SerializeField] public Transform Camera;
    [SerializeField] public Transform StopButton;
    [SerializeField] public SubmitData SubmitDataScript;

    
    void Update()
    {
        StopButton.rotation = Quaternion.Euler(90, Camera.transform.eulerAngles.y, 0); // Stop button rotates with camera
    }

    public void QuitGameButton()
    {
        SubmitDataScript.Submit();
        Application.Quit();
    }
}
