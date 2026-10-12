using UnityEngine;
using UnityEngine.InputSystem;

public class FallingItem : MonoBehaviour
{
    [SerializeField] private ItemType type = ItemType.Good;
    [SerializeField] private int points = 10;
    [SerializeField] private float fallSpeed = 3f;
    [SerializeField] private float bottomLimit = -6f;

    private void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

        if (transform.position.y < bottomLimit)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.GetComponent<BasketController>()) return;

        GameEvents.RaiseItemCaught(new ItemData(type, points));
        Destroy(gameObject);
    }
}