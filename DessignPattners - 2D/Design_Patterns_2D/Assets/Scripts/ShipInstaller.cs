using System;
using DesignPatterns.Ship.Samples;
using UnityEngine;

namespace DesignPatterns.Ship
{
    public class ShipInstaller : MonoBehaviour
    {
        [SerializeField] private bool _useJoystick;
        [SerializeField] private Joystick _joystick;
        [SerializeField] private Ship _ship;

        private void Awake()  => _ship.Configure(GetInput());
                                                               
        private IInput GetInput()
        {
            if (_useJoystick)
                return new JoystickInputAdapter(_joystick);
            
            Destroy(_joystick.gameObject);
            return new UnityInputAdapter();
        }
    }
}