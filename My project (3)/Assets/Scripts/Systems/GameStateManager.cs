using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    private void OnEnable()  => GameEvents.OnPlayerDied += HandlePlayerDied;
    private void OnDisable() => GameEvents.OnPlayerDied -= HandlePlayerDied;

    private void Start()
    {
        Time.timeScale = 1f;
    }

    private void HandlePlayerDied()
    {
        Time.timeScale = 0f;          // freezes items and basket
        GameEvents.RaiseGameOver();
    }

    // Called by the Restart button
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}