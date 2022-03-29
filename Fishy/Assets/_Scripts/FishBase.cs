using System;
using _Scripts.FishSizes;
using UnityEngine;

public class FishBase : MonoBehaviour {
    public FishSize Size {
        get => size;
    }

    [SerializeField] private FishSize size = FishSize.S;

    public void SetSize(FishSize newSize) {
        size = newSize;
        OnSizeChanged(newSize);
    }

    private void OnSizeChanged(FishSize newSize) {
        transform.localScale = newSize.MapToScale();
    }

    private void OnValidate() {
        OnSizeChanged(size);
    }
}