using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Transform resetTransform;
    [SerializeField] GameObject player;
    [SerializeField] Camera playerHead;

    [ContextMenu("Reset Position")]
    public void ResetPositon()
    {
        var rotationAngleY = resetTransform.rotation.eulerAngles.y - 
                        playerHead.transform.rotation.eulerAngles.y;
        player.transform.Rotate(0, rotationAngleY, 0);

        var distanceDiff = resetTransform.position - 
                        playerHead.transform.position;
        player.transform.position += distanceDiff;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ResetPositon();
        }
    }
}
