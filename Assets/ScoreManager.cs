using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    public static bool gameOver = false;
    private float timeLeft = 30f;

    public Text displayText;

    void Start()
    {
        score = 0;
        gameOver = false;
        timeLeft = 30f;
    }

    void Update()
    {
        if (!gameOver)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0f)
            {
                timeLeft = 0f;
                gameOver = true;
            }
        }

        if (displayText != null)
        {
            displayText.text = gameOver
                ? "Game Over!\nFinal Score: " + score
                : "Score: " + score + "\nTime: " + Mathf.CeilToInt(timeLeft);
        }
    }
}