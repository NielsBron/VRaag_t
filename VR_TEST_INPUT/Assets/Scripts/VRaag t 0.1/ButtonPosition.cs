using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPosition : MonoBehaviour
{
    [SerializeField] public Transform lookAt;
    [SerializeField] Camera playerHead;
    [SerializeField] public Transform RedButton;

    public void Update()
    {
        RedButton.LookAt(lookAt, Vector3.up);
        RedButton.Rotate(0f, 180f, 0f);
        //RedButton.position = RedButton.position;//
        RedButton.position = new Vector3(RedButton.position.x,RedButton.position.y,RedButton.position.z);
    }
}
