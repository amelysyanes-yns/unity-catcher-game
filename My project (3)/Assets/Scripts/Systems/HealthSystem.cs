using UnityEngine;
using UnityEngine.InputSystem;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] private int maxHealth = 3;
    private int health;

    private void OnEnable()  => GameEvents.OnItemCaught += HandleItemCaught;
    private void OnDisable() => GameEvents.OnItemCaught -= HandleItemCaught;

    private void Start()
    {
        health = maxHealth;
        GameEvents.RaiseHealthChanged(health);
    }

    private void HandleItemCaught(ItemData item)
    {
        if (item.Type != ItemType.Bomb) return;

        health--;
        GameEvents.RaiseHealthChanged(health);

        if (health <= 0)
            GameEvents.RaisePlayerDied();
    }
}