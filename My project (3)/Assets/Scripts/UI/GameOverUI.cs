using UnityEngine;
using UnityEngine.InputSystem;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    private void OnEnable()  => GameEvents.OnGameOver += Show;
    private void OnDisable() => GameEvents.OnGameOver -= Show;

    private void Start() => panel.SetActive(false);

    private void Show() => panel.SetActive(true);
}