using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{
    public Transform testObjectPosition;
    public Transform Camera;

    public GameObject LoadingScreen;
    public GameObject LoadingBarFill;
    public GameObject LoadingBar;
    public GameObject Logo;
    public GameObject LogoNiels;

    public GameObject BlackScreen;

    [Header("SkyBox Materials")]
    [SerializeField] public Material BlackSkybox;
    [SerializeField] public Material WhiteSkybox;

    public void Start()
    {
        testObjectPosition.rotation = Quaternion.Euler(0, Camera.transform.eulerAngles.y, 0);
        BlackScreen.SetActive(true);
        StartCoroutine(BeginGame());
    }

    IEnumerator BeginGame()
    {
        RenderSettings.skybox = WhiteSkybox;
        yield return new WaitForSeconds (1.0f);
        BlackScreen.GetComponent<Animation>().Play("FadeOut");
        yield return new WaitForSeconds (1.0f);
        BlackScreen.SetActive(false);
        testObjectPosition.rotation = Quaternion.Euler(0, Camera.transform.eulerAngles.y, 0);
        LoadingScreen.SetActive(true);
        Logo.GetComponent<Animation>().Play("FadeIn");
        LoadingBar.GetComponent<Animation>().Play("FadeIn");
        yield return new WaitForSeconds (2.0f);
        LoadingBarFill.GetComponent<Animation>().Play("LoadingBarFill");
        yield return new WaitForSeconds (3.0f);
        Logo.GetComponent<Animation>().Play("FadeOutLogo");
        LoadingBar.GetComponent<Animation>().Play("FadeOutLoadingBar");
        LoadingBarFill.GetComponent<Animation>().Play("FadeOutLoadingBarFill");
        yield return new WaitForSeconds (2.0f);
        LogoNiels.SetActive(true);
        LogoNiels.GetComponent<Animation>().Play("FadeIn");
        yield return new WaitForSeconds (2.0f);
        LogoNiels.GetComponent<Animation>().Play("FadeOutLogoNiels");
        yield return new WaitForSeconds (1.0f);
        LoadingScreen.SetActive(false);

        testObjectPosition.rotation = Quaternion.Euler(0, Camera.transform.eulerAngles.y, 0);
        yield return new WaitForSeconds (1.0f);
        BlackScreen.SetActive(true);
        BlackScreen.GetComponent<Animation>().Play("FadeIn");
        yield return new WaitForSeconds (2.0f);
        SceneManager.LoadScene(1);
    }
}
