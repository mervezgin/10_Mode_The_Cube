﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(3.5f, 1.0f, 3.3f, 0.4f);
    }
    
    void Update()
    {
        transform.Rotate(15.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
