using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animals;
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;

    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    private void SpawnRandomAnimal() {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animals.Length);

        Instantiate(animals[animalIndex], spawnPos, animals[animalIndex].transform.rotation);
    }
}
