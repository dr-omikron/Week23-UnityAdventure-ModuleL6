using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Utilities.Reactive;
using _Archero.Develop.Runtime.Utilities.StateMachineCore;
using UnityEngine;

namespace _Archero.Develop.Runtime.Gameplay.Features.AI.States
{
    public class RotateToTargetState : State, IUpdatableState
    {
        private readonly ReactiveVariable<Entity> _currentTarget;
        private readonly ReactiveVariable<Vector3> _rotationDirection;
        private readonly Transform _transform;

        public RotateToTargetState(Entity entity)
        {
            _currentTarget = entity.CurrentTarget;
            _rotationDirection = entity.RotationDirection;
            _transform = entity.Transform;
        }

        public void Update(float deltaTime)
        {
            if(_currentTarget.Value != null)
                _rotationDirection.Value = (_currentTarget.Value.Transform.position - _transform.position).normalized;
        }
    }
}
