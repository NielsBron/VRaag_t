using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;

public class TutorialController : MonoBehaviour
{
    [Header("Controller Tutorial")]
    [SerializeField]public GameObject ControllerParent;
    [SerializeField]public GameObject Controller;
    [SerializeField]public GameObject RedCircle;
    [SerializeField]public GameObject Check;

    [Header("Audio")]
    [SerializeField] public AudioSource Tutorial;

    [Header("Booleans")]
    [SerializeField] public bool ButtonisPressed = false;
    [SerializeField] public bool ButtonIsPressable = false;
    [SerializeField] public bool ButtonisPressedOnce = false;

    [Header("Tutorial Manager")]
    [SerializeField] public UIAssistant UIAssistantScript;


    void Start()
    {
        StartCoroutine(StartTutorial());
    }

    IEnumerator StartTutorial()
    {
        yield return new WaitForSeconds(1.0f);
        UIAssistantScript.ControllerStart();
        ControllerParent.SetActive(true);
        ButtonIsPressable = true;
    }
    void Update()
    {
        if (ButtonisPressed == true && ButtonisPressedOnce == false)
        {
            UIAssistantScript.ControllerEnd();
            Check.SetActive(true);
            RedCircle.SetActive(false);
            NextTutorial1();
            ButtonisPressed = false;
            ButtonisPressedOnce = true;
        }
    }

    void NextTutorial1()
    {
        StartCoroutine(NextTutorial());
    }

    IEnumerator NextTutorial()
    {
        yield return new WaitForSeconds (3.0f);
        ControllerParent.SetActive(false);
        UIAssistantScript.Tutorial_Controller = true;
    }
}

