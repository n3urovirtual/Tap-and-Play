using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraColor : MonoBehaviour
{
    public List<Color> colorList = new List<Color>();
    Camera cam;
    void Start()
    {
        cam = GetComponent<Camera>();
        cam.backgroundColor = colorList[Random.Range(0, colorList.Count)];
    }
}
