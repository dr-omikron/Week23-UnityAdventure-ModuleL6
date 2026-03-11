using UnityEngine;

namespace _Archero.Develop.Runtime.Gameplay.Features.InputFeature
{
    public class DesktopInput : IInputService
    {
        private const string HorizontalAxisName = "Horizontal";
        private const string VerticalAxisName = "Vertical";
        private const string MouseXAxisName = "Mouse X";
        private const KeyCode FireKey = KeyCode.Mouse0;

        public bool IsEnabled { get; set; } = true;

        public Vector3 AxisDirection
        {
            get
            {
                if (IsEnabled == false)
                    return Vector3.zero;

                return new Vector3(Input.GetAxisRaw(HorizontalAxisName), 0, Input.GetAxisRaw(VerticalAxisName));
            }
        }

        public float MouseXAxis
        {
            get
            {
                if (IsEnabled == false)
                    return 0;

                return Input.GetAxisRaw(MouseXAxisName);
            }
        }

        public bool IsFireKeyPressed
        {
            get
            {
                if (IsEnabled == false)
                    return false;

                return Input.GetKeyDown(FireKey);
            }
        }
    }
}
