using UnityEngine;

namespace DesignPatterns.Ship
{
    public class Ship : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private Transform _myTransform; 

        private void Awake()
        {
            _myTransform = transform;
        }

        private void Update()
        {
            var direction = GetDirection();
            Move(direction);
        }

        private void Move(Vector2 direction)
        {
        
        }

        private Vector2 GetDirection()
        {
            return new Vector2();
        }
    }
}

