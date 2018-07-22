using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reticule : MonoBehaviour
{
    CameraRaycaster cameraRaycaster;
    // Use this for initialization
    void Start()
    {

        cameraRaycaster = FindObjectOfType<CameraRaycaster>();
    }

    // Update is called once per frame
    void Update()
    {
        print(cameraRaycaster.layerHit);
    }

}

