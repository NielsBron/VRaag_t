using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialButtons : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] public GameObject StartButton;
    [SerializeField] public GameObject StartVideoButton;

    [Header("Audio")]
    [SerializeField] public AudioSource Tutorial;

    [Header("Scripts")]
    [SerializeField] public UIAssistant UIAssistantScript;

    [Header("Canvas")]
    [SerializeField] public GameObject Canvas;
    [SerializeField] public GameObject Arrow1Canvas;
    [SerializeField] public GameObject Arrow2Canvas;
    [SerializeField] public GameObject RedButtonCanvas;
    [SerializeField] public GameObject BlueButtonCanvas;

    [Header("Button Booleans")]
    [SerializeField] public Button startButton;
    [SerializeField] public Button RedButton;
    [SerializeField] public Button BlueButton;
    [SerializeField] public Button startVideoButton;
    [SerializeField] public bool RedButtonClicked = false;
    [SerializeField] public bool RedButtonTimeOver = false;
    [SerializeField] public bool BlueButtonClicked = false;
    [SerializeField] public bool BlueButtonTimeOver = false;
    [SerializeField] public float waitTime = 10;


/////////////////////////// TUTORIAL ///////////////////////////////////


    void Awake()
    {
        StartCoroutine(BeginTutorial());
    }

    IEnumerator BeginTutorial()
    {
        UIAssistantScript.ButtonStart();
        yield return new WaitForSeconds (1.0f);
        StartButton.SetActive(true);
    }

    public void StartBtn1()
    {
        StartCoroutine(StartBtn());
        StartButton.SetActive(false);
    }
    
    IEnumerator StartBtn()
    {
        Canvas.GetComponent<Canvas>().enabled = false;
        UIAssistantScript.RodeKnop();
        
        yield return new WaitForSeconds(0.0f);
        RedButtonCanvas.GetComponent<Canvas>().enabled = true;
        Arrow1Canvas.SetActive(true);

        /////Wait the amount of waittime before another voiceover is initiated
        yield return new WaitForSeconds(waitTime);
        RedButtonTimeOver = true;


        StartButton.SetActive(false);
        startButton.enabled = false;
    }

    IEnumerator RedButtonNotClicked()
    {
        RedButtonTimeOver = false;
        Debug.Log("Functie: RedButtonNotClicked");
        UIAssistantScript.RodeKnop();
        yield return new WaitForSeconds(waitTime);
        RedButtonTimeOver = true;
    }
    IEnumerator BlueButtonNotClicked()
    {
        BlueButtonTimeOver = false;
        Debug.Log("Functie: BlueButtonNotClicked");
        UIAssistantScript.BlauweKnop();
        yield return new WaitForSeconds(waitTime);
        BlueButtonTimeOver = true;
    }

/// tutorial 02 ///

    public void BtnRedStart()
    {
        StartCoroutine(BtnRed());
        RedButtonClicked = true;
    }

    IEnumerator BtnRed()
    {
        UIAssistantScript.BlauweKnop();
        RedButtonCanvas.GetComponent<Canvas>().enabled = false;
        Arrow1Canvas.SetActive(false);

        BlueButtonCanvas.GetComponent<Canvas>().enabled = true;
        Arrow2Canvas.SetActive(true);

        yield return new WaitForSeconds(waitTime);
        BlueButtonTimeOver = true;
    }

/// tutorial 03 ///

    public void BtnBlueStart()
    {
       StartCoroutine(BtnBlue());
       BlueButtonClicked = true;
    }

    IEnumerator BtnBlue()
    {
        BlueButtonTimeOver = false;
        UIAssistantScript.ButtonEndStart();
        BlueButtonCanvas.GetComponent<Canvas>().enabled = false;
        Arrow2Canvas.SetActive(false);
        Canvas.GetComponent<Canvas>().enabled = true;
        yield return new WaitForSeconds (4.0f);
        StartVideoButton.SetActive(true); 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            BtnBlueStart();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            BtnRedStart();
        }

        if (RedButtonTimeOver == true && RedButtonClicked == false)
        {
            StartCoroutine(RedButtonNotClicked());
            Debug.Log("update if-statement red");
        }

        if (BlueButtonTimeOver == true && BlueButtonClicked == false)
        {
            StartCoroutine(BlueButtonNotClicked());
            Debug.Log("update if-statement blue");
        }
    }
}
