using UnityEngine;
using System.Windows;

public class background : MonoBehaviour
{
    public Color Background = Color.white;
    Camera cm;

    void Awake()
    {
        cm = GetComponent<Camera>();
    }

    void Start()
    {

        Camera.main.backgroundColor = Background;
    }

    void Update()
    {

    }

    public void SetBackgroundColor(string brightness) {
        if (brightness == "dark") {
            Camera.main.backgroundColor = new Color(22,22,22);
        } else {
            Camera.main.backgroundColor = Color.white;
        }
    }
}