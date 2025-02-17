using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI playerScoreText;

    [ContextMenu("Increase Score")]
    public void AddScore(int addToScore)
    {
        playerScore += addToScore;
        playerScoreText.text = playerScore.ToString();
    }
}
