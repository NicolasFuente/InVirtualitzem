using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDInfoManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!XRSettings.isDeviceActive)
        {
            Debug.Log("No hay ning�n dispositivo VR cargado");
        }
        else if (XRSettings.isDeviceActive &&
       (XRSettings.loadedDeviceName == "Mock HMD" || XRSettings.loadedDeviceName
       == "MockHMD Display"))
        {
            Debug.Log("Est� cargado Mock HMD display");
        }
        else
        {
            Debug.Log("Est� cargado el dispositivo " +
            XRSettings.loadedDeviceName);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
