using System.Collections;
using System.Collections.Generic;
using MLAPI;
using UnityEngine;

public class Mounter : NetworkBehaviour
{
    public GameObject CameraMountPoint;
 
    void Start()
    {
        if (IsLocalPlayer)
        {
            Transform cameraTransform = FindObjectOfType<Camera>().gameObject.transform;  //Find main camera which is part of the scene instead of the prefab
            cameraTransform.parent = CameraMountPoint.transform;  //Make the camera a child of the mount point
            cameraTransform.position = CameraMountPoint.transform.position;  //Set position/rotation same as the mount point
            cameraTransform.rotation = CameraMountPoint.transform.rotation;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
