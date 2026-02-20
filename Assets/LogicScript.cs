using UnityEngine;
using UnityEngine.UI;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    [ContextMenu("Add Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }
}
