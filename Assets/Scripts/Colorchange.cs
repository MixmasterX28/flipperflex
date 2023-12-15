using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorchange : MonoBehaviour
{
    [SerializeField] MeshRenderer varmeshRenderer;


    void Start()
    {
        varmeshRenderer = GetComponent<MeshRenderer>();
    }
    public void ChangeColor1()
    {
        varmeshRenderer.material.color = Random.ColorHSV();
    }
}
