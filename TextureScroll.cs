﻿using UnityEngine;

public class TextureScroll : MonoBehaviour
{
    public float scrollSpeed;
    public bool scrollBackground = true;

    Material backgroundMaterial;

    private void Awake()
    {
        backgroundMaterial = GetComponent<Renderer>().material;

    }

    private void FixedUpdate()
    {
        if (scrollBackground)
        {
            Vector2 offset = new Vector2(scrollSpeed * Time.time, 0f);
            backgroundMaterial.mainTextureOffset = offset;
        }
    }
}
