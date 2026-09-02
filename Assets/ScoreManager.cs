using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    public static bool gameOver = false;

    private float timeLeft = 30f;

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
    }

    void OnGUI()
    {
        GUI.skin.label.fontSize = 40;
        GUI.Label(new Rect(40, 40, 400, 80), "Score: " + score);
        GUI.Label(new Rect(40, 110, 400, 80), "Time: " + Mathf.CeilToInt(timeLeft));

        if (gameOver)
        {
            GUI.Label(new Rect(40, 180, 600, 80), "Game Over! Final Score: " + score);
        }
    }
}