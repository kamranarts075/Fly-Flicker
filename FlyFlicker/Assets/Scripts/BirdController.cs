using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour
{
    public GameManager gameManager;
    public Rigidbody2D birdRB;
    public float flySpeed;
    public float maxHeight = 5f;
    public float minHeight = -5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        birdRB.freezeRotation = true;

        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameOver)
        {
            return;
        }

        if (Input.GetMouseButton(0) && transform.position.y < maxHeight)
        {
            birdRB.linearVelocity = Vector2.up * flySpeed;
        }

        if (transform.position.y >= maxHeight)
        {
            gameManager.GameOver();
        }

        if (transform.position.y <= minHeight)
        {
            gameManager.GameOver();

            StartCoroutine(RestartGame());
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameManager.isGameOver)
        {
            return;
        }

        if (collision.gameObject.CompareTag("Pipe"))
        {
            gameManager.GameOver();
        }
    }

    private IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}