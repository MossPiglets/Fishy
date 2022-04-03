using _Scripts;
using _Scripts.FishSizes;
using UnityEngine;

public class FishBase : MonoBehaviour {
    public FishSize Size {
        get => size;
    }

    [SerializeField] private FishSize size = FishSize.S;
    private Mouth mouth;

    private void Start() {
        mouth = GetComponentInChildren<Mouth>();
        if (mouth == null) Debug.LogError("Mouth not found in children");
        mouth.Eaten += OnFishEat;
    }

    public void SetSize(FishSize newSize) {
        size = newSize;
        OnSizeChanged(newSize);
    }

    private void OnSizeChanged(FishSize newSize) {
        transform.localScale = newSize.MapToScale();
    }

    protected virtual void OnFishEat(object sender, EatEventArgs args) {}

    public virtual void Die() {
        Destroy(this);
    }
    
    private void OnValidate() {
        OnSizeChanged(size);
    }
}