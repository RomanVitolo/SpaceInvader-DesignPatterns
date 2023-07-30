using UnityEngine;

namespace DesignPatterns.Ship
{
    public class UnityInputAdapter : IInput
    {
        public Vector2 GetDirection()
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");

            return new Vector2(horizontal, vertical);
        }
    }
}