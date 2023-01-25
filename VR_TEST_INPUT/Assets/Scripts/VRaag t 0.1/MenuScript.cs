using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject StartButton;
    public GameObject CreditsButton;
    public GameObject QuitButton;
    public GameObject Logo;
    public GameObject CreditsText;
    public GameObject BlackScreen;
    public void LoadScene()
    {
        StartCoroutine(StartGame());
    }
    public void Start()
    {
        StartCoroutine(StartMenu());
    }

    IEnumerator StartMenu()
    {
        BlackScreen.SetActive(true);
        yield return new WaitForSeconds (1.0f);
        BlackScreen.GetComponent<Animation>().Play("FadeOut");
        yield return new WaitForSeconds (1.0f);
        BlackScreen.SetActive(false);
    }

    IEnumerator StartGame()
    {
        BlackScreen.SetActive(true);
        BlackScreen.GetComponent<Animation>().Play("FadeIn");
        yield return new WaitForSeconds (1.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit game");
    }
    public void Credits()
    {
        Logo.SetActive(false);
        StartButton.SetActive(false);
        CreditsButton.SetActive(false);
        QuitButton.SetActive(false);
        CreditsText.SetActive(true);
    }
    public void CreditsQuit()
    {
        Logo.SetActive(true);
        StartButton.SetActive(true);
        CreditsButton.SetActive(true);
        QuitButton.SetActive(true);
        CreditsText.SetActive(false);
    }
}
