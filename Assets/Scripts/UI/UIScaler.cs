﻿using UnityEngine;

public class UIScaler : MonoBehaviour
{
    private const float _uiScaleMultiplier = 0.001f;

    public float UIScale = 1.0f;

    public void OnValidate()
    {
        var rectTransform = transform.GetComponentInChildren<RectTransform>();
        if (rectTransform) rectTransform.localScale = Vector3.one * UIScale * _uiScaleMultiplier;
    }
}