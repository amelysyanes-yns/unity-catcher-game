using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    private void OnEnable()  => GameEvents.OnScoreChanged += UpdateText;
    private void OnDisable() => GameEvents.OnScoreChanged -= UpdateText;

    private void UpdateText(int score)
    {
        scoreText.text = $"Score: {score}";
    }
}
