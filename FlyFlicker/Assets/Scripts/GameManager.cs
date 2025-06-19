using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI playerScoreText;
    public bool isGameOver = false;

    [ContextMenu("Increase Score")]
    public void AddScore(int addToScore)
    {
        playerScore += addToScore;
        playerScoreText.text = playerScore.ToString();
        playerScoreText.color = Color.white;
    }

    public void ShowSpawnRateIncreaseCue()
    {
        StartCoroutine(FlashScoreColor());
    }

    private IEnumerator FlashScoreColor()
    {
        Color color = playerScoreText.color;
        Vector3 originalScale = playerScoreText.transform.localScale;

        playerScoreText.color = Color.red;
        playerScoreText.transform.localScale = originalScale * 1.2f;

        yield return new WaitForSeconds(0.3f);

        playerScoreText.color = Color.white;
        playerScoreText.transform.localScale = originalScale;
    }

    public void GameOver()
    {
        isGameOver = true;

        var bird = GameObject.FindGameObjectWithTag("Player");
        if (bird != null)
        {
            var rb = bird.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                rb.freezeRotation = false;
            }
        }
    }
}