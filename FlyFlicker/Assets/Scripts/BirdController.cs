using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D birdRB;
    public float flySpeed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        birdRB.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            birdRB.linearVelocity = Vector2.up * flySpeed;
        }
    }
}