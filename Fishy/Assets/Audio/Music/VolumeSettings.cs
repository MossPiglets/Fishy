using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour {
    [SerializeField] private AudioMixer _mixer;
    [SerializeField] private Toggle _soundToggle;

    private void Awake() {
        _soundToggle.onValueChanged.AddListener(value => {
            var mixerVolume = "MasterVolume";
            if (value) _mixer.SetFloat(mixerVolume, 0f);
            else _mixer.SetFloat(mixerVolume, -80f);
        });
    }
}
