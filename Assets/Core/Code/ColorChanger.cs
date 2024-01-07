using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField]
    private Color newColor = Color.cyan;

    // Start is called before the first frame update
    void Start()
    {
        ChangeColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ChangeColor()
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.color = newColor;
    }
}
