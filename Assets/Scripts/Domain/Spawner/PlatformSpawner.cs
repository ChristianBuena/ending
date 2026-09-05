using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{

    private GameObject platformPrefab;
    private Transform cameraTransform;
    private float platformSize = 20f;

    private float lastSpawnX = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraTransform.position.x + platformSize > lastSpawnX)
        {
            SpawnPlatform();
        }
    }

    private void SpawnPlatform()
    {
        lastSpawnX += platformSize;

        Instantiate(platformPrefab,
                    new Vector3(lastSpawnX,0,0),
                    Quaternion.identity
                    );
    }
}
