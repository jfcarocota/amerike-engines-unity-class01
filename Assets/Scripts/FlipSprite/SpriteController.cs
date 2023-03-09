using System;
using UnityEngine;

namespace FlipSprite
{
    [Serializable]
    public class SpriteController : ISpriteController
    {
        [SerializeField]
        private SpriteRenderer _spriteRenderer;
        public SpriteRenderer SprRenderer { get => _spriteRenderer; set => _spriteRenderer = value; }
        public bool IsFlippedOnX { get => SprRenderer.flipX; set => SprRenderer.flipX = value; }
    }
}