using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject blockPrefab;
    public int rows = 5;
    public int columns = 8;
    public float spacing = 1.1f;

    void Start()
    {
        SpawnBricks();
    }

    void SpawnBricks()
    {

        float cameraHeight = Camera.main.orthographicSize * 2f;
        float maxSpawnHeight = (cameraHeight * 4f/5f) / 2f;
        float startX = -columns / 2f ;
        float startY = maxSpawnHeight ;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                Vector2 position = new Vector2(startX + col * spacing, startY - row * spacing);
                GameObject brick = Instantiate(blockPrefab, position, Quaternion.identity);

                Brick brickObj = brick.GetComponent<Brick>();
                if (brickObj != null) {
                    brickObj.health = Random.Range(1, 5);
                }
            }
        }
    }
}
