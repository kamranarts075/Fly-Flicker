using Unity.Mathematics;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D birdRB;
    public float flapForce;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            birdRB.linearVelocity = Vector3.up * flapForce;
        }

        birdRB.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
}