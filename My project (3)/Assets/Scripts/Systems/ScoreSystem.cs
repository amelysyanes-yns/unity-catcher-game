using UnityEngine;
using UnityEngine.InputSystem;
public class ScoreSystem : MonoBehaviour
{
    private int score;

    private void OnEnable()  => GameEvents.OnItemCaught += HandleItemCaught;
    private void OnDisable() => GameEvents.OnItemCaught -= HandleItemCaught;

    private void Start()
    {
        GameEvents.RaiseScoreChanged(score); // show the starting 0
    }

    private void HandleItemCaught(ItemData item)
    {
        if (item.Type != ItemType.Good) return;

        score += item.Points;
        GameEvents.RaiseScoreChanged(score);
    }
}