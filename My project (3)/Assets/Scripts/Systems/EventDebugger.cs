using UnityEngine;
using UnityEngine.InputSystem;

public class EventDebugger : MonoBehaviour
{
    private void OnEnable()  => GameEvents.OnItemCaught += HandleItemCaught;
    private void OnDisable() => GameEvents.OnItemCaught -= HandleItemCaught;

    private void HandleItemCaught(ItemData item)
    {
        Debug.Log($"Caught a {item.Type} worth {item.Points}");
    }
}