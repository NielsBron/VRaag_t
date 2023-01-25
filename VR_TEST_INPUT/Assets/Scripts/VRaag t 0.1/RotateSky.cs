using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSky : MonoBehaviour
{
    public float RotateAmount;

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", RotateAmount);
    }

    public void KijkRichtingScene01()
    {
        RotateAmount = 180;
    }

    public void KijkRichtingScene02()
    {
        RotateAmount = 180;
    }

    public void KijkRichtingScene03()
    {
        RotateAmount = 180;
    }
    
    public void KijkRichtingScene04()
    {
        RotateAmount = 180;
    }

    public void KijkRichtingScene05()
    {
        RotateAmount = 180;
    }

    public void KijkRichtingScene06()
    {
        RotateAmount = 180;
    }

    public void KijkRichtingScene07()
    {
        RotateAmount = 180;
    }

    public void KijkRichtingScene08()
    {
        RotateAmount = 180;
    }

    public void KijkRichtingScene09()
    {
        RotateAmount = 180;
    }
}
