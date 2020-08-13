// ping-pong animate background color
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

    public void setBackgroundColor(string rgbString)
    {
        string[] part = rgbString.Split(',');
        cam.backgroundColor = new Color(float.Parse(part[0]), float.Parse(part[1]), float.Parse(part[2]));
    }
}