using UnityEngine;

namespace DesignPatterns.Ship
{
    public class Ship : MonoBehaviour
    {
        [SerializeField] private float _speed;
        
        private IInput _input;
        private Transform _myTransform;
        private Camera _camera;
        
        private bool _isCameraNotNull;
        private float minClamp = 0.03f;
        private float maxClamp = 0.97f;

        private void Awake()
        {
            _camera = Camera.main;
            _myTransform = transform;
        }

        public void Configure(IInput input)
        {
            _input = input;
        }

        private void Update()
        {
            var direction = GetDirection();
            Move(direction);
        }

        private void Move(Vector2 direction)
        {
            _myTransform.Translate((direction * (_speed * Time.deltaTime)));

            ClampFinalPosition();
        }

        private void ClampFinalPosition()
        {
            Vector3 viewportPoint = _camera.WorldToViewportPoint(_myTransform.position);
            viewportPoint.x = Mathf.Clamp(viewportPoint.x, minClamp, maxClamp);
            viewportPoint.y = Mathf.Clamp(viewportPoint.y, minClamp, maxClamp);
            _myTransform.position = _camera.ViewportToWorldPoint(viewportPoint);
        }

        private Vector2 GetDirection() => _input.GetDirection();
    }
}

