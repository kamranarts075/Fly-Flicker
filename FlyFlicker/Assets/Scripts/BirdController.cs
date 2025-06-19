using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D birdRB;
    public float flySpeed;
    public float maxHeight = 5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        birdRB.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && transform.position.y < maxHeight)
        {
            birdRB.linearVelocity = Vector2.up * flySpeed;
        }

        else if (transform.position.y > maxHeight)
        {
            transform.position = new Vector3(transform.position.x, maxHeight, transform.position.z);

            if (birdRB.linearVelocity.y > 0)
            {
                birdRB.linearVelocity = new Vector2(birdRB.linearVelocity.x, 0);
            }
        }
    }
}