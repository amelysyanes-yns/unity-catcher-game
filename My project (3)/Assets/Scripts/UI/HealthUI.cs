using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private TMP_Text healthText;

    private void OnEnable()  => GameEvents.OnHealthChanged += UpdateText;
    private void OnDisable() => GameEvents.OnHealthChanged -= UpdateText;

    private void UpdateText(int health)
    {
        healthText.text = $"Health: {health}";
    }
}