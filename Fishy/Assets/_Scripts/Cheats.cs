using UnityEditor;
using UnityEngine;

namespace _Scripts {
    public class Cheats : MonoBehaviour
    {
        [MenuItem("Cheats/Immortal Toggle")]
        public static void ImmortalToggle()
        {
            if (Application.isPlaying)
            {
                // make fish immortal here
            } else {
                Debug.LogError("Not in play mode.");
            }
        }
    }
}
