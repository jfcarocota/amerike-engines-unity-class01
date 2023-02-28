using UnityEngine;
using UnityEngine.InputSystem;

public class Movement2D : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 0f;

    public void MoveBody(InputAction.CallbackContext ctx) => transform.Translate(Vector3.right * ctx.ReadValue<Vector2>().x * _moveSpeed * Time.fixedTime);

}
