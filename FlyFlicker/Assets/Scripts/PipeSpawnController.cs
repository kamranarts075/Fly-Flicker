using UnityEngine;
using System.Collections;

public class PipeSpawnController : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject pipe;
    public float minSpawnRate;
    public float maxSpawnRate;
    public float spawnRateDecreasePerPoint;
    private float timer = 0;
    public float heightOffset;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        float currentSpawnRate = Mathf.Max(minSpawnRate, maxSpawnRate - (gameManager.playerScore * spawnRateDecreasePerPoint));

        if (timer < currentSpawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
