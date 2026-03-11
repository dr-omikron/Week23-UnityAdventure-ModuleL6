using UnityEngine;

namespace _Archero.Develop.Runtime.Gameplay.Features.InputFeature
{
    public interface IInputService
    {
        bool IsEnabled { get; set; }
        Vector3 AxisDirection { get; }
        float MouseXAxis { get; }
        bool IsFireKeyPressed { get; }
    }
}
