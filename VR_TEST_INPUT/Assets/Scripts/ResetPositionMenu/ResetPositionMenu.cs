using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPositionMenu : MonoBehaviour
{
    public Transform testObjectPosition;
    public Transform Camera;

    public void Start()
    {
        testObjectPosition.rotation = Quaternion.Euler(0, Camera.transform.eulerAngles.y, 0);
    }

    public void ResetPositionAfterScene()
    {
        testObjectPosition.rotation = Quaternion.Euler(0, Camera.transform.eulerAngles.y, 0);
    }
}
