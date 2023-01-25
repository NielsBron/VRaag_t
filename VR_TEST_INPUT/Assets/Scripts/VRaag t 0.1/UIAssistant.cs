using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAssistant : MonoBehaviour
{
    [Header("TextWriter")]
    [SerializeField] public TextWriter textWriter;
    public Text messageText;

    [Header("Audio")]
    [SerializeField] public AudioSource Tutorial;

    [SerializeField] public AudioClip Tutorial01; // Welkom bij de VR-Training grensoverschrijdend gedrag /////// Je gaat zo kijken naar een aantal scenes waarin grensoverschrijdend gedrag wordt vertoont
    [SerializeField] public AudioClip Tutorial02; // Aan het eind van de scene is het aan jou om aan te geven in hoeverre je de scene wel of niet vervelend vond
    [SerializeField] public AudioClip Tutorial03; // Nu volgt er een korte oefening om je wegwijs te maken in de VR omgeving
    [SerializeField] public AudioClip Tutorial04; // Goed Gedaan!
    [SerializeField] public AudioClip Tutorial05; // Klik op de startknop om de volgende oefening te beginnen

    [SerializeField] public AudioClip Tutorial06; // kijk nu om je heen en klik op de rode knop
    [SerializeField] public AudioClip Tutorial07; // kijk nu om je heen en klik op de (kleur) knop
    [SerializeField] public AudioClip Tutorial08; // nothing
    [SerializeField] public AudioClip Tutorial09; // Gefeliciteerd, je hebt de oefening voltooid
    [SerializeField] public AudioClip Tutorial10; // Bedankt voor het bekijken van de scenes. Je mag nu de headset af doen.
    [SerializeField] public AudioClip Tutorial11; // Bedankt voor het bekijken van de scenes. Je mag nu de headset af doen.

    [Header("Sound Effects")]

    [SerializeField] public AudioSource SoundEffects;
    [SerializeField] public AudioClip ClickNoise1;
    [SerializeField] public AudioClip ClickNoise2;
    [SerializeField] public AudioClip ClickNoise3;
    [SerializeField] public AudioClip ClickNoise4;
    [SerializeField] public AudioClip ClickNoise5;

    [SerializeField] public AudioClip SceneBeoordelenAudio;

    [Header("Tutorial Scripts")]
    [SerializeField] public GameObject TutorialControllerScript;
    [SerializeField] public GameObject TutorialButtonsScript;
    [SerializeField] public PlayerController PlayerControllerScript;

    [Header("Tutorial Manager")]
    [SerializeField] public bool Tutorial_Start = false;
    [SerializeField] public bool Tutorial_Controller = false;
    [SerializeField] public bool Tutorial_Buttons = false;

    [Header("Test")]
    [SerializeField] public Transform testObjectPosition;
    [SerializeField] public Transform Camera;
    [SerializeField] public GameObject BlackScreenCanvas;
    [SerializeField] public GameObject BlackScreen;

    [Header("Canvas")]
    [SerializeField] public GameObject MainCanvas;

    private void Awake()
    {
        BlackScreenCanvas.SetActive(true);
        messageText = transform.Find("messageText").GetComponent<Text>();
        Application.targetFrameRate = -1;
        StartCoroutine(StartWriting());
    }


    IEnumerator StartWriting()
    {
        yield return new WaitForSeconds(1.5f);
        PlayerControllerScript.ResetPositon();
        BlackScreen.GetComponent<Animation>().Play("FadeOut");
        MainCanvas.GetComponent<Canvas>().enabled = true;
        yield return new WaitForSeconds(1.2f);
        Tutorial.PlayOneShot(Tutorial01);
        textWriter.AddWriter(messageText, "Welkom bij de VR-Training grensoverschrijdend gedrag", .075f, true);
        yield return new WaitForSeconds(5.0f); //time of the message above

        textWriter.AddWriter(messageText, "Je gaat zo kijken naar een aantal scenes waarin grensoverschrijdend gedrag wordt vertoont", .06f, true);
        yield return new WaitForSeconds(5.0f); //time of the message above

        yield return new WaitForSeconds(2.0f); // Time between audio 1 and 2

        Tutorial.PlayOneShot(Tutorial02);
        textWriter.AddWriter(messageText, "Aan het eind van de scene is het aan jou om aan te geven in hoeverre je de scene wel of niet vervelend vond", .06f, true);
        yield return new WaitForSeconds(Tutorial02.length); //Length of audio clip 2

        yield return new WaitForSeconds(2.0f); // Time between audio 2 and 3

        Tutorial.PlayOneShot(Tutorial03);
        textWriter.AddWriter(messageText, "Nu volgt er een korte oefening om je wegwijs te maken in de VR omgeving", .06f, true);
        yield return new WaitForSeconds(Tutorial03.length); //Length of audio clip 3

        yield return new WaitForSeconds(1.5f); // Time between audio 3 and 4

        Tutorial_Start = true;
    }

    public void ControllerStart()
    {
        Tutorial.PlayOneShot(Tutorial04);
        textWriter.AddWriter(messageText, "Klik met je wijsvinger op de knop aan de achterkant van de controller", .05f, true);
    }

    public void ControllerEnd()
    {
        Tutorial.Stop();
        Tutorial.PlayOneShot(Tutorial05);
        textWriter.AddWriter(messageText, "Goed Gedaan", .06f, true);
    }

    public void ButtonStart()
    {
        Tutorial.Stop();
        Tutorial.PlayOneShot(Tutorial06);
        textWriter.AddWriter(messageText, "Klik op de startknop om de volgende oefening te beginnen.", .05f, true);
    }

    public void RodeKnop()
    {
        Tutorial.Stop();
        Tutorial.PlayOneShot(Tutorial07);
        textWriter.AddWriter(messageText, "Kijk nu om je heen en klik op de persoon met het rode shirt.", .05f, true);
    }

    public void BlauweKnop()
    {
        Tutorial.Stop();
        Tutorial.PlayOneShot(Tutorial08);
        textWriter.AddWriter(messageText, "Kijk nu om je heen en klik op de persoon met het blauwe vest.", .05f, true);
    }

    public void ButtonEndStart()
    {
        StartCoroutine(ButtonEnd());
    }

    IEnumerator ButtonEnd()
    {
        Tutorial.Stop();
        Tutorial.PlayOneShot(Tutorial09);
        textWriter.AddWriter(messageText, "Gefeliciteerd, je hebt de oefening voltooid.", .06f, true);
        yield return new WaitForSeconds (Tutorial09.length);

        yield return new WaitForSeconds (1.0f);
        
        Tutorial.PlayOneShot(Tutorial10);
        textWriter.AddWriter(messageText, "Je kan nu op de startknop klikken om te beginnen met het bekijken van de scenes.", .06f, true);
    }

    public void EndGame()
    {
        Tutorial.Stop();
        Tutorial.PlayOneShot(Tutorial11);
        textWriter.AddWriter(messageText, "Bedankt voor het bekijken van de scenes. Je mag nu de headset af doen.", .05f, true);
    }

    public void playAudioSceneBeoordelen()
    {
        Tutorial.PlayOneShot(SceneBeoordelenAudio);
    }

    void Update()
    {
        if (Tutorial_Start == true)
        {
            TutorialControllerScript.SetActive(true);
        }

        if (Tutorial_Controller == true)
        {
            TutorialControllerScript.SetActive(false);
            TutorialButtonsScript.SetActive(true);
        }

        if (Tutorial_Buttons == true)
        {
            TutorialButtonsScript.SetActive(false);
        }
    }
}