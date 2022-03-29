using System;
using UnityEngine;

namespace _Scripts.FishSizes {
    public static class FishSizeExtensions {
        public static Vector3 MapToScale(this FishSize size) {
            return size switch {
                FishSize.SSS => new Vector3(1, 1),
                FishSize.SS => new Vector3(1.1f, 1.1f),
                FishSize.S => new Vector3(1.2f, 1.2f),
                FishSize.M => new Vector3(1.3f, 1.3f),
                FishSize.L => new Vector3(1.5f, 1.5f),
                FishSize.XL => new Vector3(2f, 2f),
                FishSize.XXL => new Vector3(2.5f, 2.5f),
                FishSize.XXXL => new Vector3(3f, 3f),
                FishSize.Chonker => new Vector3(3.5f, 3.5f),
                FishSize.SuperChonker => new Vector3(4f, 4f),
                FishSize.Boss => new Vector3(5f, 5f),
                _ => throw new ArgumentOutOfRangeException(nameof(size), size, null)
            };
        }
    }
}