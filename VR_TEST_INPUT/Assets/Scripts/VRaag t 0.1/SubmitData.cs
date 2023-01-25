using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class SubmitData : MonoBehaviour
{
    [Header("ToggleGroups")]
    [SerializeField] public GameObject inputName;
    [SerializeField] public ToggleGroup theOptions1;
    [SerializeField] public ToggleGroup theOptions2;
    [SerializeField] public ToggleGroup theOptions3;
    [SerializeField] public ToggleGroup theOptions4;
    [SerializeField] public ToggleGroup theOptions5;
    [SerializeField] public ToggleGroup theOptions6;
    [SerializeField] public ToggleGroup theOptions7;
    [SerializeField] public ToggleGroup theOptions8;
    [SerializeField] public ToggleGroup theOptions9;

    [Header("Integers")]
    [SerializeField] public int Options1Number = 0;
    [SerializeField] public int Options2Number = 0;
    [SerializeField] public int Options3Number = 0;
    [SerializeField] public int Options4Number = 0;
    [SerializeField] public int Options5Number = 0;
    [SerializeField] public int Options6Number = 0;
    [SerializeField] public int Options7Number = 0;
    [SerializeField] public int Options8Number = 0;
    [SerializeField] public int Options9Number = 0;

    [Header("Strings")]
    [SerializeField] private string Name;
    [SerializeField] private string Options1;
    [SerializeField] private string Options2;
    [SerializeField] private string Options3;
    [SerializeField] private string Options4;
    [SerializeField] private string Options5;
    [SerializeField] private string Options6;
    [SerializeField] private string Options7;
    [SerializeField] private string Options8;
    [SerializeField] private string Options9;

    [Header("Booleans")]
    [SerializeField] public bool Data1 = false;
    [SerializeField] public bool Data2 = false;
    [SerializeField] public bool Data3 = false;
    [SerializeField] public bool Data4 = false;
    [SerializeField] public bool Data5 = false;
    [SerializeField] public bool Data6 = false;
    [SerializeField] public bool Data7 = false;
    [SerializeField] public bool Data8 = false;
    [SerializeField] public bool Data9 = false;

    [Header("AnswerNotFilled")]
    [SerializeField] public string Option1NotFilled = "0";
    [SerializeField] public string Option2NotFilled = "0";
    [SerializeField] public string Option3NotFilled = "0";
    [SerializeField] public string Option4NotFilled = "0";
    [SerializeField] public string Option5NotFilled = "0";
    [SerializeField] public string Option6NotFilled = "0";
    [SerializeField] public string Option7NotFilled = "0";
    [SerializeField] public string Option8NotFilled = "0";
    [SerializeField] public string Option9NotFilled = "0";



    [Header("Scripts")]
    [SerializeField] public SceneManagerScript SceneManagerScript;

    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSfTwSI-cS6bm3TU_TXb3wFMcMlXm2KHhSfxl-tkkI5DbjQ6Rw/formResponse";

    public void SendData1()
    {
        Data1 = true;
    }
    public void SendData2()
    {
        Data2 = true;
    }
    public void SendData3()
    {
        Data3 = true;
    }
    public void SendData4()
    {
        Data4 = true;
    }
    public void SendData5()
    {
        Data5 = true;
    }
    public void SendData6()
    {
        Data6 = true;
    }
    public void SendData7()
    {
        Data7 = true;
    }
    public void SendData8()
    {
        Data8 = true;
    }
    public void SendData9()
    {
        Data9 = true;
    }

    public void Submit()
    {
        Name = inputName.GetComponent<InputField>().text;
        //if data 1 has been send, return the data, if not return 0
        if (Data1 == true)
        {
            Options1 = theOptions1.GetFirstActiveToggle().transform.GetChild(1).GetComponent<Text>().text;
        }
        else
        {
            Options1 = Option1NotFilled;
        }

        //////////////// 2 /////////////////
        if (Data2 == true)
        {
            Options2 = theOptions2.GetFirstActiveToggle().transform.GetChild(1).GetComponent<Text>().text;
        }
        else
        {
            Options2 = Option2NotFilled;
        }

        //////////////// 3 /////////////////
        if (Data3 == true)
        {
            Options3 = theOptions3.GetFirstActiveToggle().transform.GetChild(1).GetComponent<Text>().text;
        }
        else
        {
            Options3 = Option3NotFilled;
        }

        //////////////// 4 //////////////////
        if (Data4 == true)
        {
            Options4 = theOptions4.GetFirstActiveToggle().transform.GetChild(1).GetComponent<Text>().text;
        }
        else
        {
            Options4 = Option4NotFilled;
        }
        
        //////////////// 5 /////////////////
        if (Data5 == true)
        {
            Options5 = theOptions5.GetFirstActiveToggle().transform.GetChild(1).GetComponent<Text>().text;
        }
        else
        {
            Options5 = Option5NotFilled;
        }
        
        //////////////// 6 /////////////////
        if (Data6 == true)
        {
            Options6 = theOptions6.GetFirstActiveToggle().transform.GetChild(1).GetComponent<Text>().text;
        }
        else
        {
            Options6 = Option6NotFilled;
        }

        //////////////// 7 /////////////////
        if (Data7 == true)
        {
            Options7 = theOptions7.GetFirstActiveToggle().transform.GetChild(1).GetComponent<Text>().text;
        }
        else
        {
            Options7 = Option7NotFilled;
        }       
        
        //////////////// 8 /////////////////
        if (Data8 == true)
        {
            Options8 = theOptions8.GetFirstActiveToggle().transform.GetChild(1).GetComponent<Text>().text;
        }
        else
        {
            Options8 = Option8NotFilled;
        }

        //////////////// 8 /////////////////
        if (Data9 == true)
        {
            Options9 = theOptions9.GetFirstActiveToggle().transform.GetChild(1).GetComponent<Text>().text;
        }
        else
        {
            Options9 = Option9NotFilled;
        }
        
        
        /*Options2 = theOptions2.GetFirstActiveToggle().transform.GetChild(1).GetComponent<Text>().text;
        Options3 = theOptions3.GetFirstActiveToggle().transform.GetChild(1).GetComponent<Text>().text;
        Options4 = theOptions4.GetFirstActiveToggle().transform.GetChild(1).GetComponent<Text>().text;
        Options5 = theOptions5.GetFirstActiveToggle().transform.GetChild(1).GetComponent<Text>().text;
        Options6 = theOptions6.GetFirstActiveToggle().transform.GetChild(1).GetComponent<Text>().text;
        Options7 = theOptions7.GetFirstActiveToggle().transform.GetChild(1).GetComponent<Text>().text;
        Options8 = theOptions8.GetFirstActiveToggle().transform.GetChild(1).GetComponent<Text>().text;
        Options9 = theOptions9.GetFirstActiveToggle().transform.GetChild(1).GetComponent<Text>().text;*/

        StartCoroutine(Post(Name, Options1, Options2, Options3, Options4, Options5, Options6, Options7, Options8, Options9));
        
        Debug.Log(Name + " " + Options1 + " " + Options2 + " " + Options3 + " " + Options4 + " " + Options5 + " " + Options6
        + " " + Options7 + " " + Options8 + " " + Options9);

        SceneManagerScript.Completetion();
    }

    IEnumerator Post(string name, string options1, string options2, string options3, string options4, string options5, 
    string options6, string options7, string options8, string options9)

    {
        Debug.Log("Post started");
        WWWForm form = new WWWForm();

        form.AddField("entry.89347151", options1);
        form.AddField("entry.374917355", name);
        form.AddField("entry.208989915", options2);
        form.AddField("entry.1957066336", options3);
        form.AddField("entry.1732086746", options4);
        form.AddField("entry.1873075487", options5);
        form.AddField("entry.245447327", options6);
        form.AddField("entry.1673238762", options7);
        form.AddField("entry.1169523795", options8);
        form.AddField("entry.994797207", options9);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        yield return www.SendWebRequest();
    }
}

