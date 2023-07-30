using UnityEngine;

namespace DesignPatterns.Ship.Samples
{
    public class JoystickInputAdapter : IInput
    {
        private readonly Joystick _joystick;

        public JoystickInputAdapter(Joystick joystick) => _joystick = joystick;
        
        public Vector2 GetDirection() => new Vector2(_joystick.Horizontal, _joystick.Vertical);
    }
}