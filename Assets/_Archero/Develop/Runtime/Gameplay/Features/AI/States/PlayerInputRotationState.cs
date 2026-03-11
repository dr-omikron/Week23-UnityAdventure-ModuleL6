using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Gameplay.Features.InputFeature;
using _Archero.Develop.Runtime.Utilities.Reactive;
using _Archero.Develop.Runtime.Utilities.StateMachineCore;
using UnityEngine;

namespace _Archero.Develop.Runtime.Gameplay.Features.AI.States
{
    public class PlayerInputRotationState : State, IUpdatableState
    {
        private readonly IInputService _inputService;
        private readonly ReactiveVariable<Vector3> _rotationDirection;

        public PlayerInputRotationState(Entity entity, IInputService inputService)
        {
            _inputService = inputService;
            _rotationDirection = entity.RotationDirection;
        }

        public void Update(float deltaTime)
        {
            _rotationDirection.Value = Quaternion.Euler(0f, _inputService.MouseXAxis * 10, 0f) * _rotationDirection.Value;
        }
    }
}
