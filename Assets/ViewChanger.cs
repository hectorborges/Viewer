using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewChanger : MonoBehaviour
{
    public static ViewChanger Instance;
    public Transform[] views;
    public Transform defaultView;
    public Camera cam;
    public float panSpeed;
    public float rotationSpeed;

    Vector3 targetView;
    Quaternion targetRotation;
    Vector3 velocity;

    public bool ChangingView { get; protected set; }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        cam = Camera.main;
    }

    public void ChangeView(int view)
    {
        targetView = views[view].position;
        targetRotation = views[view].rotation;
        ChangingView = true;
    }

    public void ChangeTarget(Transform newTarget)
    {
        Viewer.Instance.UpdateTarget(newTarget);
    }

    public void DefaultView()
    {
        targetView = defaultView.position;
        targetRotation = defaultView.rotation;
        ChangingView = true;
    }

    private void LateUpdate()
    {
        if(ChangingView)
        {
            if (Vector3.Distance(cam.transform.position, targetView) > .25f)
                cam.transform.position = Vector3.SmoothDamp(cam.transform.position, targetView, ref velocity, panSpeed);
            else
                ChangingView = false;

            cam.transform.rotation = Quaternion.Lerp(cam.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }

    }
}
