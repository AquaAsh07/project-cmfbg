using UnityEngine;
using TMPro;

/// <summary>
/// LEGACY — Game Manager (Vertical Slice)
/// Score, timer, kickoff reset, win detection.
/// </summary>
public class GameManager : MonoBehaviour
{
    [Header("Match")]
    public float matchDuration = 180f;
    public BallPhysics ball;
    public Transform kickoffSpot;

    [Header("UI (optional)")]
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI messageText;

    private int leftScore;
    private int rightScore;
    private float timeLeft;
    private bool matchOver;

    void Start()
    {
        timeLeft = matchDuration;
        if (ball != null)
        {
            ball.OnGoal += HandleGoal;
            ball.ResetToCenter(kickoffSpot != null ? kickoffSpot.position : Vector3.zero);
        }
        UpdateUI();
        ShowMessage("Kick Off!");
    }

    void Update()
    {
        if (matchOver) return;
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0f)
        {
            timeLeft = 0f;
            EndMatch();
        }
        UpdateUI();
    }

    void HandleGoal(bool rightTeamScored)
    {
        if (matchOver) return;
        if (rightTeamScored) rightScore++; else leftScore++;
        ShowMessage(rightTeamScored ? "GOAL — Right Team!" : "GOAL — Left Team!");
        Invoke(nameof(Kickoff), 1.5f);
        UpdateUI();
    }

    void Kickoff()
    {
        if (ball != null && kickoffSpot != null)
            ball.ResetToCenter(kickoffSpot.position);
        ShowMessage("");
    }

    void EndMatch()
    {
        matchOver = true;
        string result = leftScore == rightScore ? "Full Time — Draw!"
            : leftScore > rightScore ? "Full Time — Left Team Win!"
            : "Full Time — Right Team Win!";
        ShowMessage(result);
    }

    void UpdateUI()
    {
        if (scoreText != null) scoreText.text = $"{leftScore} — {rightScore}";
        if (timerText != null)
        {
            int m = Mathf.FloorToInt(timeLeft / 60f);
            int s = Mathf.FloorToInt(timeLeft % 60f);
            timerText.text = $"{m:00}:{s:00}";
        }
    }

    void ShowMessage(string msg)
    {
        if (messageText != null) messageText.text = msg;
        Debug.Log(msg);
    }

    public void RestartMatch()
    {
        leftScore = 0; rightScore = 0;
        timeLeft = matchDuration;
        matchOver = false;
        Kickoff();
        UpdateUI();
    }
}
