using UnityEngine;

public class PipeSpawnController : MonoBehaviour
{
    public GameObject pipeSpawnRB;
    public float spawnRate;
    private float nextSpawn = 0;
    public float heightOffset = 10;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (nextSpawn < spawnRate)
        {
            nextSpawn += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            nextSpawn = 0;
        }
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        
        Instantiate(pipeSpawnRB, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
