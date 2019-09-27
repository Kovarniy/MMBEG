using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetHover : MonoBehaviour
{

    private Color basicColor = Color.white;
    private Color hoverColor = Color.red;
    private Renderer renderer;
    private Image thisImage;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material.color = basicColor;
    }

    void OnMouseEnter()
    {
        GetComponent<Image>().color = hoverColor;
        // renderer.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        GetComponent<Image>().color = basicColor;
        // renderer.material.color = basicColor;
    }
}
