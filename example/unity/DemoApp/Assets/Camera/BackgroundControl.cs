﻿// ping-pong animate background color
using UnityEngine;

public class BackgroundControl : MonoBehaviour
{
    public Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
    }

    void Update()
    {
    }

    public void SetBackgroundColor(string rgbString)
    {
        string[] part = rgbString.Split(',');
        Color color = new Color(float.Parse(part[0]), float.Parse(part[1]), float.Parse(part[2]));
        cam.backgroundColor = color;
    }
}