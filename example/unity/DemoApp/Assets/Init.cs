using UnityEngine;

public class Init : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetCarColor(string colorString)
    {
        string[] part = colorString.Split(',');
        Color color = new Color(float.Parse(part[0]), float.Parse(part[1]), float.Parse(part[2]));
        Material body = Resources.Load("materials/tesla_white", typeof(Material)) as Material;
        body.color = color;
    }
}
