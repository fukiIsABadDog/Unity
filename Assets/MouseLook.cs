using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
  public enum RotationAxes
    {
        MouseXandY = 0,
        MouseX = 1,
        MouseY = 2
    }

    public RotationAxes axes = RotationAxes.MouseXandY;

    public float sensitivityHor = 9.0f;

    public float sensitivityVert = 9.0f;
    public float minVert = -45.0f;
    public float maxVert = 45.0f;
    private float verticalRotation = 0;


  void Update()
    {
        if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(0,Input.GetAxis("Mouse X") * sensitivityHor, 0);
        }
        else if(axes == RotationAxes.MouseY)
        {
            verticalRotation -= Input.GetAxis("Mouse Y") * sensitivityVert;
            verticalRotation = Mathf.Clamp(verticalRotation, minVert, maxVert);
            float horizontalRotation = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(verticalRotation, horizontalRotation, 0);
        }
        else
        {

        }
    }
}
