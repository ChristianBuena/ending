using UnityEngine;
using UnityEngine.PlayerLoop;

public class CoinsSpawner : MonoBehaviour
{
    public GameObject coinsPrefab;
    private Vector2 lastKnownPosition;
    

    public void SpawnCoins(Vector2 CurrentPos)
    {
        Instantiate(
            coinsPrefab,
            CurrentPos,
            Quaternion.identity
        );
    }

    public void SaveLastPositionSpawn(Vector2 finalPos)
    {
       lastKnownPosition = finalPos;
        SpawnCoins(lastKnownPosition);
    }
}
