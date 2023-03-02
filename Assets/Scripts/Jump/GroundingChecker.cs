using UnityEngine;

namespace Jump
{
    public class GroundingChecker : IGroundingChecker
    {
        public float GroundRayDistance { get; set; }
        public Vector3 GroundRayPosition { get; set; }
        public LayerMask GroundLayer { get; set; }
        public Color RayColor { get; set; }
        public bool GroundingByRaycast(Vector3 objectPosition) => Physics2D.Raycast(objectPosition + GroundRayPosition, Vector2.down,
            GroundRayDistance, GroundLayer);
    }
}