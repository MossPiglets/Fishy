using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyFishSpawner : MonoBehaviour {
    [SerializeField] private List<GameObject> enemyFishPrefabs;
    [SerializeField] private float spawnCooldownSeconds = 1f;
    private BoxCollider2D _collider;
    private float _spawnMin;
    private float _spawnMax;
    private Transform _dynamic;
    void Start() {
        _collider = GetComponent<BoxCollider2D>();
        var bounds = _collider.bounds;
        _spawnMin = bounds.min.y;
        _spawnMax = bounds.max.y;
        _dynamic = GameObject.FindWithTag("Dynamic").transform;
        StartCoroutine(SpawnFish());
    }

    public IEnumerator SpawnFish() {
        while (true) {
            var randomEnemyFish = enemyFishPrefabs[Random.Range(0, enemyFishPrefabs.Count - 1)];
            var randomY = Random.Range(_spawnMin, _spawnMax);
            var fish = Instantiate(randomEnemyFish, new Vector3(transform.position.x, randomY, transform.position.z), transform.rotation, _dynamic);
            fish.GetComponent<FishEnemy>().Speed = Random.Range(1, 4);
            yield return new WaitForSeconds(spawnCooldownSeconds);
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.CompareTag("Enemy") && Math.Abs(transform.rotation.y - other.transform.rotation.y) > 0.001) {
            Destroy(other.gameObject);
        }
    }
}