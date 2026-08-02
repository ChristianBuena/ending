
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject zombiePrefab;
    [SerializeField] private float timer = 0f;
    [SerializeField] private float spawnInterval = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;

        if(timer >= spawnInterval)
        {
            SpawnZombie();
            timer = 0f;
        }
    }

    private void SpawnZombie()
    {
        float RandomX = Random.Range(-10f,10f);
        float RandomY = Random.Range(-5f,5f);

        Vector3 randomPosition = new Vector3(RandomX, RandomY, -1f);
    
        
        Instantiate(
            zombiePrefab,
            randomPosition,
            Quaternion.identity
        );
    }

}
