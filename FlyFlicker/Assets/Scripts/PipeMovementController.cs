using UnityEngine;

public class PipeMovementController : MonoBehaviour
{
    public float moveSpeed;
    public float deadZone = -20;
    public float verticalAmplitude = 1f;
    public float verticalFrequency = 1f;

    private Vector3 startPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startPosition + Vector3.up * Mathf.Sin(Time.time * verticalFrequency) * verticalAmplitude + Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}