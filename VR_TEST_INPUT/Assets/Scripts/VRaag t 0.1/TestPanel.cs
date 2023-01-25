using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPanel : MonoBehaviour
{
    [Header("Canvas")]
    [SerializeField] public GameObject TestPanelCanvas;
    [SerializeField] public GameObject MainCanvas;

    [Header("Scripts")]
    [SerializeField] public SceneManagerScript SceneManagerScript;
    [SerializeField] public TutorialButtons TutorialButtonsScript;
    [SerializeField] public TutorialController TutorialControllerScript;
    [SerializeField] public QuitGame QuitGameScript;
    [SerializeField] public UIAssistant UIAssistantScript;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            TestPanelCanvas.GetComponent<Canvas>().enabled = true;
            SceneManagerScript.Debugging = true;
            MainCanvas.SetActive(false);
            UIAssistantScript.Tutorial.Stop();
        }
    }

    public void CloseMenu()
    {
        TestPanelCanvas.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.Debugging = false;
    }

    public void WatchScene01()
    {
        SceneManagerScript.PlayScene01();
        SceneManagerScript.AnswerData1.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData2.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData3.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData4.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData5.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData6.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData7.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData8.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData9.GetComponent<Canvas>().enabled = false;
    }
    public void WatchScene02()
    {
        SceneManagerScript.PlayScene02();
        SceneManagerScript.AnswerData1.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData2.GetComponent<Canvas>().enabled = true;
        SceneManagerScript.AnswerData3.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData4.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData5.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData6.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData7.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData8.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData9.GetComponent<Canvas>().enabled = false;
    }
    public void WatchScene03()
    {
        SceneManagerScript.PlayScene03();
        SceneManagerScript.AnswerData1.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData2.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData3.GetComponent<Canvas>().enabled = true;
        SceneManagerScript.AnswerData4.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData5.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData6.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData7.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData8.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData9.GetComponent<Canvas>().enabled = false;
    }
    public void WatchScene04()
    {
        SceneManagerScript.PlayScene04();
        SceneManagerScript.AnswerData1.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData2.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData3.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData4.GetComponent<Canvas>().enabled = true;
        SceneManagerScript.AnswerData5.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData6.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData7.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData8.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData9.GetComponent<Canvas>().enabled = false;
    }
    public void WatchScene05()
    {
        SceneManagerScript.PlayScene05();
        SceneManagerScript.AnswerData1.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData2.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData3.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData4.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData5.GetComponent<Canvas>().enabled = true;
        SceneManagerScript.AnswerData6.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData7.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData8.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData9.GetComponent<Canvas>().enabled = false;
    }
    public void WatchScene06()
    {
        SceneManagerScript.PlayScene06();
        SceneManagerScript.AnswerData1.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData2.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData3.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData4.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData5.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData6.GetComponent<Canvas>().enabled = true;
        SceneManagerScript.AnswerData7.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData8.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData9.GetComponent<Canvas>().enabled = false;
    }
    public void WatchScene07()
    {
        SceneManagerScript.PlayScene07();
        SceneManagerScript.AnswerData1.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData2.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData3.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData4.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData5.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData6.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData7.GetComponent<Canvas>().enabled = true;
        SceneManagerScript.AnswerData8.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData9.GetComponent<Canvas>().enabled = false;
    }
    public void WatchScene08()
    {
        SceneManagerScript.PlayScene08();
        SceneManagerScript.AnswerData1.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData2.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData3.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData4.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData5.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData6.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData7.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData8.GetComponent<Canvas>().enabled = true;
        SceneManagerScript.AnswerData9.GetComponent<Canvas>().enabled = false;
    }
    public void WatchScene09()
    {
        SceneManagerScript.PlayScene09();
        SceneManagerScript.AnswerData1.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData2.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData3.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData4.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData5.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData6.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData7.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData8.GetComponent<Canvas>().enabled = false;
        SceneManagerScript.AnswerData9.GetComponent<Canvas>().enabled = true;
    }



}
