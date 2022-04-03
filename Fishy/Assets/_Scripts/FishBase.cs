using _Scripts.FishSizes;
using UnityEngine;

namespace _Scripts {
    public class FishBase : MonoBehaviour {
        public FishSize Size {
            get => size;
        }

        [SerializeField] private FishSize size = FishSize.S;
        private Mouth mouth;
        protected AudioSource Chomp;
        [SerializeField] protected GameObject deadFish;

        private void OnEnable() {
            mouth = GetComponentInChildren<Mouth>();
            if (mouth == null) Debug.LogError("Mouth not found in children");
            mouth.Eaten += OnFishEat;
            Chomp = GetComponent<AudioSource>();
        }

        private void OnDisable() {
            mouth.Eaten -= OnFishEat;
        }

        public void SetSize(FishSize newSize) {
            Debug.Log(newSize);
            size = newSize;
            OnSizeChanged(newSize);
        }

        private void OnSizeChanged(FishSize newSize) {
            transform.localScale = newSize.MapToScale();
        }

        protected virtual void OnFishEat(object sender, EatEventArgs args) {
            Debug.Log(args.Fish.tag);
        }

        public virtual void Die() {
            var dynamic = GameObject.FindWithTag("Dynamic");
            var corpse = Instantiate(deadFish, transform.position, transform.rotation, dynamic.transform);
            corpse.transform.localScale = transform.localScale;
            Destroy(this.gameObject);
        }
    
        private void OnValidate() {
            OnSizeChanged(size);
        }
    }
}