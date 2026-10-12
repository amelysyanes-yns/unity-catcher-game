using System;

public static class GameEvents
{
    public static event Action<ItemData> OnItemCaught;
    public static event Action<int> OnScoreChanged;
    public static event Action<int> OnHealthChanged;
    public static event Action OnPlayerDied;
    public static event Action OnGameOver;

    public static void RaiseItemCaught(ItemData item) => OnItemCaught?.Invoke(item);
    public static void RaiseScoreChanged(int score) => OnScoreChanged?.Invoke(score);
    public static void RaiseHealthChanged(int health) => OnHealthChanged?.Invoke(health);
    public static void RaisePlayerDied() => OnPlayerDied?.Invoke();
    public static void RaiseGameOver() => OnGameOver?.Invoke();
}