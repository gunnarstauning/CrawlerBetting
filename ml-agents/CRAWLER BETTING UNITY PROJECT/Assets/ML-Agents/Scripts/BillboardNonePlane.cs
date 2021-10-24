using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardNonePlane : MonoBehaviour
{
    public Camera m_Camera;

    void LateUpdate()
    {
        transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.forward);

        // The next three lines make this work only on the horizontal axis
        Vector3 eulerAngles = transform.eulerAngles;
        eulerAngles.x = 0;
        transform.eulerAngles = eulerAngles;

        transform.localPosition = new Vector3(transform.localPosition.x, 3.5f, transform.localPosition.z);

        //m_Camera.transform.rotation* Vector3.up
    }
}
