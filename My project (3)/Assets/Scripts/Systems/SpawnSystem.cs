using UnityEngine;
using UnityEngine.InputSystem;
public class SpawnSystem : MonoBehaviour
{
    [SerializeField] private GameObject goodItemPrefab;
    [SerializeField] private GameObject bombPrefab;
    [SerializeField] private float spawnInterval = 1f;
    [SerializeField] private float minInterval = 0.4f;
    [SerializeField] private float difficultyRamp = 0.02f;
    [SerializeField, Range(0f, 1f)] private float bombChance = 0.25f;
    [SerializeField] private float xRange = 7f;
    [SerializeField] private float spawnY = 6f;

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer < spawnInterval) return;

        timer = 0f;
        Spawn();
        spawnInterval = Mathf.Max(minInterval, spawnInterval - difficultyRamp);
    }

    private void Spawn()
    {
        GameObject prefab = Random.value < bombChance ? bombPrefab : goodItemPrefab;
        Vector3 pos = new Vector3(Random.Range(-xRange, xRange), spawnY, 0f);
        Instantiate(prefab, pos, Quaternion.identity);
    }
}