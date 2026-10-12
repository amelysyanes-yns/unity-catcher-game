using UnityEngine;
using UnityEngine.InputSystem;

public class BasketController : MonoBehaviour
{
    [SerializeField] private float speed = 8f;
    [SerializeField] private float xLimit = 7f;

    private void Update()
    {
        float input = 0f;

        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
            input = -1f;
        else if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
            input = 1f;

        Vector3 pos = transform.position;
        pos.x += input * speed * Time.deltaTime;
        pos.x = Mathf.Clamp(pos.x, -xLimit, xLimit);
        transform.position = pos;
    }
}