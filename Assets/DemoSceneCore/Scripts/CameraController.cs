using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Controls the Camera based on rotation
public class CameraController : MonoBehaviour {

    public Camera cam;
    private Rigidbody rb;
    //the scale at which the speed of the camera moves
    public float xLookSensitivity;// = 2.0f;
    public float yLookSensitivity;// = 2.0f;

    public bool invertY;

    public float MinimumX = -90F;
    public float MaximumX = 90F;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    public void Update () {

        CameraRotate();
    }

    public void CameraRotate()
    {
        float yRot = Input.GetAxis("Mouse X") * xLookSensitivity;
        float xRot = Input.GetAxis("Mouse Y") * yLookSensitivity;

        transform.localRotation *= Quaternion.Euler(0f, yRot, 0f);
        cam.transform.localRotation *= Quaternion.Euler(-xRot, 0f, 0f);
        cam.transform.localRotation = ClampRotationAroundXAxis(cam.transform.localRotation);

    }

    //thank u unity
    Quaternion ClampRotationAroundXAxis(Quaternion q)
    {
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1.0f;

        float angleX = 2.0f * Mathf.Rad2Deg * Mathf.Atan(q.x);

        angleX = Mathf.Clamp(angleX, MinimumX, MaximumX);

        q.x = Mathf.Tan(0.5f * Mathf.Deg2Rad * angleX);

        return q;
    }
}
