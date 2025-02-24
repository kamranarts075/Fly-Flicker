using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI playerScoreText;

    [ContextMenu("Increase Score")]
    public void AddScore(int addToScore)
    {
        playerScore += addToScore;
        playerScoreText.text = playerScore.ToString();
        playerScoreText.color = Color.black;
    }
}