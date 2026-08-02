using UnityEngine;
using UnityEngine.PlayerLoop;

public class CoinsSpawner : MonoBehaviour
{
    public GameObject coinsPrefab;
    private Vector2 lastKnownPosition;
    

    public void SpawnCoins()
    {
        Instantiate(
            coinsPrefab,
            lastKnownPosition,
            Quaternion.identity
        );
    }

    public void SaveLastPosition(Vector2 finalPos)
    {
       lastKnownPosition = finalPos;
       Debug.Log($"Saved last position: {lastKnownPosition}");

       SpawnCoins();
    }
}
