using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPresence : MonoBehaviour
{
    public List<GameObject> controllerPrefabs;
    public InputDeviceCharacteristics controllerCharacteristics;
    public InputDevice targetDevice;
    private GameObject spawnedController;

    public TutorialController TutorialControllerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, devices);

        foreach (var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }

        if(devices.Count > 0)
        {
            targetDevice = devices[0];
            GameObject prefab = controllerPrefabs.Find(controller => controller.name == targetDevice.name);
            if(prefab)
            {
                spawnedController = Instantiate(prefab, transform);
            }
            else
            {
                Debug.Log("Did not find corresponding controller model");
                spawnedController = Instantiate(controllerPrefabs[0], transform);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue) && primaryButtonValue)
        Debug.Log("Pressing Primary Button");

        targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue);
        if (triggerValue > 0.1f && TutorialControllerScript.ButtonIsPressable == true || Input.GetKeyDown(KeyCode.Escape))
        {
        //Debug.Log("Trigger pressed " + triggerValue);
        TutorialControllerScript.ButtonisPressed = true;
        }

        targetDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 primary2DAxisValue);
        if (primary2DAxisValue != Vector2.zero)
        Debug.Log("LETS GOOOOOOOOOO");
    }
}
