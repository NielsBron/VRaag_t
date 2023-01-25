using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.Android;

public class SceneManagerScript : MonoBehaviour
{
    public GameObject StartVideoButton;
    
    [Header("Scripts")]
    [SerializeField] public GameObject SubmitDataScript;
    [SerializeField] public UIAssistant UIAssistantScript;
    [SerializeField] public PlayerController PlayerControllerScript;
    public VideoPlayer videoPlayer;

    [Header("Audio Sound Effects")]

    [Header("Canvas for answers")]
    [SerializeField] public GameObject MainCanvas;
    [SerializeField] public GameObject AnswerData1;
    [SerializeField] public GameObject AnswerData2;
    [SerializeField] public GameObject AnswerData3;
    [SerializeField] public GameObject AnswerData4;
    [SerializeField] public GameObject AnswerData5;
    [SerializeField] public GameObject AnswerData6;
    [SerializeField] public GameObject AnswerData7;
    [SerializeField] public GameObject AnswerData8;
    [SerializeField] public GameObject AnswerData9;

    [Header("SkyBox Materials")]
    [SerializeField] public Material MatTest;
    [SerializeField] public Material VideoMaterial;

    [Header("Video Count")]
    [SerializeField] public float SceneCount = 0;
    [SerializeField] public float RotateAmount = 0;

    [Header("Booleans")]
    [SerializeField] public bool Toggle1isOn = false;
    [SerializeField] public bool Toggle2isOn = false;
    [SerializeField] public bool Toggle3isOn = false;
    [SerializeField] public bool Toggle4isOn = false;
    [SerializeField] public bool Toggle5isOn = false;
    [SerializeField] public bool Toggle6isOn = false;
    [SerializeField] public bool Toggle7isOn = false;
    [SerializeField] public bool Toggle8isOn = false;
    [SerializeField] public bool Toggle9isOn = false;
    [SerializeField] public bool Debugging = false;
    [SerializeField] public bool Testing;

    [Header("ToggleGroup1")]
    [SerializeField] public Toggle Toggle1_1;
    [SerializeField] public Toggle Toggle1_2;
    [SerializeField] public Toggle Toggle1_3;
    [SerializeField] public Toggle Toggle1_4;
    [SerializeField] public Toggle Toggle1_5;

    [Header("ToggleGroup2")]
    [SerializeField] public Toggle Toggle2_1;
    [SerializeField] public Toggle Toggle2_2;
    [SerializeField] public Toggle Toggle2_3;
    [SerializeField] public Toggle Toggle2_4;
    [SerializeField] public Toggle Toggle2_5;

    [Header("ToggleGroup3")]
    [SerializeField] public Toggle Toggle3_1;
    [SerializeField] public Toggle Toggle3_2;
    [SerializeField] public Toggle Toggle3_3;
    [SerializeField] public Toggle Toggle3_4;
    [SerializeField] public Toggle Toggle3_5;

    [Header("ToggleGroup4")]
    [SerializeField] public Toggle Toggle4_1;
    [SerializeField] public Toggle Toggle4_2;
    [SerializeField] public Toggle Toggle4_3;
    [SerializeField] public Toggle Toggle4_4;
    [SerializeField] public Toggle Toggle4_5;

    [Header("ToggleGroup5")]
    [SerializeField] public Toggle Toggle5_1;
    [SerializeField] public Toggle Toggle5_2;
    [SerializeField] public Toggle Toggle5_3;
    [SerializeField] public Toggle Toggle5_4;
    [SerializeField] public Toggle Toggle5_5;

    [Header("ToggleGroup6")]
    [SerializeField] public Toggle Toggle6_1;
    [SerializeField] public Toggle Toggle6_2;
    [SerializeField] public Toggle Toggle6_3;
    [SerializeField] public Toggle Toggle6_4;
    [SerializeField] public Toggle Toggle6_5;

    [Header("ToggleGroup7")]
    [SerializeField] public Toggle Toggle7_1;
    [SerializeField] public Toggle Toggle7_2;
    [SerializeField] public Toggle Toggle7_3;
    [SerializeField] public Toggle Toggle7_4;
    [SerializeField] public Toggle Toggle7_5;

    [Header("ToggleGroup8")]
    [SerializeField] public Toggle Toggle8_1;
    [SerializeField] public Toggle Toggle8_2;
    [SerializeField] public Toggle Toggle8_3;
    [SerializeField] public Toggle Toggle8_4;
    [SerializeField] public Toggle Toggle8_5;

    [Header("ToggleGroup9")]
    [SerializeField] public Toggle Toggle9_1;
    [SerializeField] public Toggle Toggle9_2;
    [SerializeField] public Toggle Toggle9_3;
    [SerializeField] public Toggle Toggle9_4;
    [SerializeField] public Toggle Toggle9_5;

    ////// SkyBox set to MenuSkybox when we start the game ///////
    void Start()
    {   
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.loopPointReached += CheckOver;
        RenderSettings.skybox = MatTest;

        if (!Permission.HasUserAuthorizedPermission(Permission.ExternalStorageRead))
        Permission.RequestUserPermission(Permission.ExternalStorageRead);

        if (!Permission.HasUserAuthorizedPermission(Permission.ExternalStorageWrite))
        Permission.RequestUserPermission(Permission.ExternalStorageWrite);

        AnswerData1.GetComponent<Canvas>().enabled = false;
        AnswerData2.GetComponent<Canvas>().enabled = false;
        AnswerData3.GetComponent<Canvas>().enabled = false;
        AnswerData4.GetComponent<Canvas>().enabled = false;
        AnswerData5.GetComponent<Canvas>().enabled = false;
        AnswerData6.GetComponent<Canvas>().enabled = false;
        AnswerData7.GetComponent<Canvas>().enabled = false;
        AnswerData8.GetComponent<Canvas>().enabled = false;
        AnswerData9.GetComponent<Canvas>().enabled = false;
    }
    
    ////// Button Script for starting the scenes after tutorial /////// 

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", RotateAmount);
    }
    public void StartPlayingScenes()
    {
        PlayScene01();
    }

    public void ResetSkyboxRotation()
    {
        RotateAmount = 0;
    }

    
    ////// ALL THE SCENES SCRIPTS ///////
    ////// URL FOR OCULUS QUEST:"/storage/emulated/0/Android/data/com.DefaultCompany.VR_TEST_INPUT/files/Scene1.mp4" //////

    public void PlayScene01()
    {
        UIAssistantScript.Tutorial.Stop();
        RenderSettings.skybox = VideoMaterial;

        Debug.Log("video started");
        videoPlayer.url = "/storage/emulated/0/Android/data/com.StudioSpinLink.VRaagt/files/Scene1.mp4";
        //videoPlayer.url = "D:/VR_videos/Videos/Scene1.mp4";
            /*if (Testing == true)
            {
                //videoPlayer.url = "D:/VR_videos/ActualScenes/Scene1.mp4";
                videoPlayer.url = "/storage/emulated/0/Android/data/com.StudioSpinLink.VRaagt/files/Scene1.mp4";
                //videoPlayer.url = "D:/VR_videos/Videos/Scene1.mp4";
            }
            if (Testing == false)
            {
                videoPlayer.url = "/storage/emulated/0/Android/data/com.StudioSpinLink.VRaagt/files/Scene1.mp4";
            }*/
        videoPlayer.Play();
        PlayerControllerScript.ResetPositon();
        ResetSkyboxRotation();
        RotateAmount = 80;
        MainCanvas.GetComponent<Canvas>().enabled = false;
        StartVideoButton.SetActive(false);
    }

    public void PlayScene02()
    {
        if (Toggle1_1.isOn || Toggle1_2.isOn || Toggle1_3.isOn || Toggle1_4.isOn || Toggle1_5.isOn || Debugging == true)
        {
            AnswerData1.GetComponent<Canvas>().enabled = false;

            RenderSettings.skybox = VideoMaterial;

            Debug.Log("video started");
                videoPlayer.url = "/storage/emulated/0/Android/data/com.StudioSpinLink.VRaagt/files/Scene2.mp4";
            //videoPlayer.url = "D:/VR_videos/Videos/Scene2.mp4";
            /*if (Testing == true)
            {
                //videoPlayer.url = "D:/VR_videos/ActualScenes/Scene2.mp4";
                videoPlayer.url = "D:/VR_videos/Videos/Scene2.mp4";
            }
            if (Testing == false)
            {
                videoPlayer.url = "/storage/emulated/0/Android/data/com.StudioSpinLink.VRaagt/files/Scene2.mp4";  
            }*/
            videoPlayer.Play();
            PlayerControllerScript.ResetPositon();
            ResetSkyboxRotation();
            RotateAmount = 28;
        }
    }

    public void PlayScene03()
    {
        if (Toggle2_1.isOn || Toggle2_2.isOn || Toggle2_3.isOn || Toggle2_4.isOn || Toggle2_5.isOn || Debugging == true)
        {
            AnswerData2.GetComponent<Canvas>().enabled = false;

            RenderSettings.skybox = VideoMaterial;

            Debug.Log("video started");
            videoPlayer.url = "/storage/emulated/0/Android/data/com.StudioSpinLink.VRaagt/files/Scene3.mp4";
            //videoPlayer.url = "D:/VR_videos/Videos/Scene3.mp4";
            /*if (Testing == true)
            {
                //videoPlayer.url = "D:/VR_videos/ActualScenes/Scene3.mp4";
                videoPlayer.url = "D:/VR_videos/Videos/Scene3.mp4";
            }
            if (Testing == false)
            {
                videoPlayer.url = "/storage/emulated/0/Android/data/com.StudioSpinLink.VRaagt/files/Scene3.mp4";  
            }*/
            videoPlayer.Play();
            PlayerControllerScript.ResetPositon();
            ResetSkyboxRotation();
            RotateAmount = -102;
        }
    }
        
    public void PlayScene04()
    {
        if (Toggle3_1.isOn || Toggle3_2.isOn || Toggle3_3.isOn || Toggle3_4.isOn || Toggle3_5.isOn || Debugging == true)
        {
            AnswerData3.GetComponent<Canvas>().enabled = false;

            RenderSettings.skybox = VideoMaterial;

            Debug.Log("video started");
            videoPlayer.url = "/storage/emulated/0/Android/data/com.StudioSpinLink.VRaagt/files/Scene4.mp4";
            //videoPlayer.url = "D:/VR_videos/Videos/Scene4.mp4";
            /*if (Testing == true)
            {
                //videoPlayer.url = "D:/VR_videos/ActualScenes/Scene4.mp4";
                videoPlayer.url = "D:/VR_videos/Videos/Scene4.mp4";
            }
            if (Testing == false)
            {
                videoPlayer.url = "/storage/emulated/0/Android/data/com.StudioSpinLink.VRaagt/files/Scene4.mp4";  
            }*/
            videoPlayer.Play();
            PlayerControllerScript.ResetPositon();
            ResetSkyboxRotation();
            RotateAmount = 90;
        }
    }

    public void PlayScene05()
    {
        if (Toggle4_1.isOn || Toggle4_2.isOn || Toggle4_3.isOn || Toggle4_4.isOn || Toggle4_5.isOn || Debugging == true)
        {
            AnswerData4.GetComponent<Canvas>().enabled = false;
            
            RenderSettings.skybox = VideoMaterial;

            Debug.Log("video started");
            videoPlayer.url = "/storage/emulated/0/Android/data/com.StudioSpinLink.VRaagt/files/Scene5.mp4";
            //videoPlayer.url = "D:/VR_videos/Videos/Scene5.mp4";
            /*if (Testing == true)
            {
                //videoPlayer.url = "D:/VR_videos/ActualScenes/Scene5.mp4";
                videoPlayer.url = "D:/VR_videos/Videos/Scene5.mp4";
            }
            if (Testing == false)
            {
                videoPlayer.url = "/storage/emulated/0/Android/data/com.StudioSpinLink.VRaagt/files/Scene5.mp4";  
            }*/
            videoPlayer.Play();
            PlayerControllerScript.ResetPositon();
            ResetSkyboxRotation();
            RotateAmount = 90;

        }
    }

    public void PlayScene06()
    {
        if (Toggle5_1.isOn || Toggle5_2.isOn || Toggle5_3.isOn || Toggle5_4.isOn || Toggle5_5.isOn || Debugging == true)
        {
            AnswerData5.GetComponent<Canvas>().enabled = false;

            RenderSettings.skybox = VideoMaterial;

            Debug.Log("video started");
            videoPlayer.url = "/storage/emulated/0/Android/data/com.StudioSpinLink.VRaagt/files/Scene6.mp4";
            //videoPlayer.url = "D:/VR_videos/Videos/Scene6.mp4";
            /*if (Testing == true)
            {
                //videoPlayer.url = "D:/VR_videos/ActualScenes/Scene6.mp4";
                videoPlayer.url = "D:/VR_videos/Videos/Scene6.mp4";
            }
            if (Testing == false)
            {
                videoPlayer.url = "/storage/emulated/0/Android/data/com.StudioSpinLink.VRaagt/files/Scene6.mp4";  
            }*/
            videoPlayer.Play();
            PlayerControllerScript.ResetPositon();
            ResetSkyboxRotation();
            RotateAmount = 90;
        }
    }

    public void PlayScene07()
    {
        if (Toggle6_1.isOn || Toggle6_2.isOn || Toggle6_3.isOn || Toggle6_4.isOn || Toggle6_5.isOn || Debugging == true)
        {
            AnswerData6.GetComponent<Canvas>().enabled = false;

            RenderSettings.skybox = VideoMaterial;

            Debug.Log("video started");
            videoPlayer.url = "/storage/emulated/0/Android/data/com.StudioSpinLink.VRaagt/files/Scene7.mp4";
            //videoPlayer.url = "D:/VR_videos/Videos/Scene7.mp4";
            /*if (Testing == true)
            {
                //videoPlayer.url = "D:/VR_videos/ActualScenes/Scene7.mp4";
                videoPlayer.url = "D:/VR_videos/Videos/Scene7.mp4";
            }
            if (Testing == false)
            {
                videoPlayer.url = "/storage/emulated/0/Android/data/com.StudioSpinLink.VRaagt/files/Scene7.mp4";  
            }*/
            videoPlayer.Play();
            PlayerControllerScript.ResetPositon();
            ResetSkyboxRotation();
            RotateAmount = 90;
        }
    }

    public void PlayScene08()
    {
        if (Toggle7_1.isOn || Toggle7_2.isOn || Toggle7_3.isOn || Toggle7_4.isOn || Toggle7_5.isOn || Debugging == true)
        {
            AnswerData7.GetComponent<Canvas>().enabled = false;

            RenderSettings.skybox = VideoMaterial;

            Debug.Log("video started");
            videoPlayer.url = "/storage/emulated/0/Android/data/com.StudioSpinLink.VRaagt/files/Scene8.mp4";
            //videoPlayer.url = "D:/VR_videos/Videos/Scene8.mp4";
            /*if (Testing == true)
            {
                //videoPlayer.url = "D:/VR_videos/ActualScenes/Scene8.mp4";
                videoPlayer.url = "D:/VR_videos/Videos/Scene8.mp4";
            }
            if (Testing == false)
            {
                videoPlayer.url = "/storage/emulated/0/Android/data/com.StudioSpinLink.VRaagt/files/Scene8.mp4";  
            }*/
            videoPlayer.Play();
            PlayerControllerScript.ResetPositon();
            ResetSkyboxRotation();
            RotateAmount = 113;
        }
    }

    public void PlayScene09()
    {
        if (Toggle8_1.isOn || Toggle8_2.isOn || Toggle8_3.isOn || Toggle8_4.isOn || Toggle8_5.isOn || Debugging == true)
        {
            AnswerData8.GetComponent<Canvas>().enabled = false;

            RenderSettings.skybox = VideoMaterial;

            Debug.Log("video started");
            videoPlayer.url = "/storage/emulated/0/Android/data/com.StudioSpinLink.VRaagt/files/Scene9.mp4";
            //videoPlayer.url = "D:/VR_videos/Videos/Scene9.mp4";
            /*if (Testing == true)
            {
                //videoPlayer.url = "D:/VR_videos/ActualScenes/Scene9.mp4";
                videoPlayer.url = "D:/VR_videos/Videos/Scene9.mp4";
            }
            if (Testing == false)
            {
                videoPlayer.url = "/storage/emulated/0/Android/data/com.StudioSpinLink.VRaagt/files/Scene9.mp4";  
            }*/
            videoPlayer.Play();
            PlayerControllerScript.ResetPositon();
            ResetSkyboxRotation();
            RotateAmount = 70;
        }
    }

    ////// This is what happens when the player submitted all data //////
        public void Completetion()
    {
        if (Toggle9_1.isOn || Toggle9_2.isOn || Toggle9_3.isOn || Toggle9_4.isOn || Toggle9_5.isOn || Debugging == true)
        {
            AnswerData9.GetComponent<Canvas>().enabled = false;
            MainCanvas.GetComponent<Canvas>().enabled = true;
            UIAssistantScript.EndGame();
        }
    }

    ////// Checks if the video is over ///////

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        Debug.Log("Video Is Over");
        SceneCount++;
        CheckScene();
    }

    ////// Checks the number of the video that was played and opens submit canvas ///////

    void CheckScene()
    {
        if (SceneCount == 1)
        {
            UIAssistantScript.playAudioSceneBeoordelen();
            AnswerData1.GetComponent<Canvas>().enabled = true;
        }
        if (SceneCount == 2)
        {
            UIAssistantScript.playAudioSceneBeoordelen();
            AnswerData2.GetComponent<Canvas>().enabled = true;
        }
        if (SceneCount == 3)
        {
            UIAssistantScript.playAudioSceneBeoordelen();
            AnswerData3.GetComponent<Canvas>().enabled = true;
        }
        if (SceneCount == 4)
        {
            UIAssistantScript.playAudioSceneBeoordelen();
            AnswerData4.GetComponent<Canvas>().enabled = true;
        }
        if (SceneCount == 5)
        {
            UIAssistantScript.playAudioSceneBeoordelen();
            AnswerData5.GetComponent<Canvas>().enabled = true;
        }
        if (SceneCount == 6)
        {
            UIAssistantScript.playAudioSceneBeoordelen();
            AnswerData6.GetComponent<Canvas>().enabled = true;
        }
        if (SceneCount == 7)
        {
            UIAssistantScript.playAudioSceneBeoordelen();
            AnswerData7.GetComponent<Canvas>().enabled = true;
        }
        if (SceneCount == 8)
        {
            UIAssistantScript.playAudioSceneBeoordelen();
            AnswerData8.GetComponent<Canvas>().enabled = true;
        }
        if (SceneCount == 9)
        {
            UIAssistantScript.playAudioSceneBeoordelen();
            AnswerData9.GetComponent<Canvas>().enabled = true;
        }
    }

    ////// This is what happens when the game closes ///////
    
    void OnApplicationQuit()
    {
        Debug.Log("Application ending after " + Time.time + " seconds");
        RenderSettings.skybox = MatTest;
    }

    public void ClickNoiseOne()
    {
        //UIAssistantScript.SoundEffects.ClickNoise1.pla;
    }
    /*void Update()
    {

        if (Toggle1_1.isOn || Toggle2_1.isOn || Toggle3_1.isOn || Toggle4_1.isOn || Toggle5_1.isOn || Toggle6_1.isOn || Toggle7_1.isOn|| Toggle8_1.isOn|| Toggle9_1.isOn)
        {
            Toggle1isOn = true;
        }
        else
        {
            Toggle1IfStatement == false;
        }
            if (Toggle1isOn == true)
            {
                Debug.Log("PlaySound");
                Toggle1isOn = false;       
            }
    }*/
}
