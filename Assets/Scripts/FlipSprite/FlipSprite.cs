using UnityEngine;
using UnityEngine.InputSystem;

namespace FlipSprite
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class FlipSprite : MonoBehaviour
    {
        [SerializeReference] 
        private ISpriteController _spriteController;

        public FlipSprite()
        {
            Inject(new SpriteController());
            _spriteController.SprRenderer = GetComponent<SpriteRenderer>();
        }
        
        public void Inject(ISpriteController spriteController) => _spriteController = spriteController;

        public void FlipSpriteOnMoveX(InputAction.CallbackContext ctx) => _spriteController.IsFlippedOnX =
            !(ctx.ReadValue<Vector2>().x > 0f) && (ctx.ReadValue<Vector2>().x  < 0f || _spriteController.IsFlippedOnX);
    }
}
