using System;
using Random = UnityEngine.Random;

namespace _Scripts.FishSizes {
    public class FishSizeSpawnRate {
        public static FishSize GetRandom() {
            var random = Random.Range(0f, 1f);
            if (random <= 0.05) return FishSize.SSS;
            if (random <= 0.15) return FishSize.SS;
            if (random <= 0.25) return FishSize.S;
            if (random <= 0.50) return FishSize.M;
            if (random <= 0.75) return FishSize.L;
            if (random <= 0.80) return FishSize.XL;
            if (random <= 0.85) return FishSize.XXL;
            if (random <= 0.90) return FishSize.XXXL;
            if (random <= 0.95) return FishSize.Chonker;
            if (random <= 0.99) return FishSize.SuperChonker;
            if (random <= 1) return FishSize.Boss;
            throw new InvalidOperationException("Number was out of range!");
        }
    }
}