using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Utilities.Reactive;
using _Archero.Develop.Runtime.Utilities.StateMachineCore;
using UnityEngine;

namespace _Archero.Develop.Runtime.Gameplay.Features.AI.States
{
    public class ForwardDirectionTeleportState : State, IUpdatableState
    {
        private const float DistanceThreshold = 0.1f;
        private readonly Entity _entity;
        private readonly ReactiveEvent<Vector3> _teleportationRequest;
        private readonly ReactiveVariable<float> _teleportationMaxRadius;
        private readonly Transform _transform;
        
        private float _distanceToTarget;

        public ForwardDirectionTeleportState(Entity entity)
        {
            _entity = entity;
            _teleportationRequest = entity.TeleportationRequest;
            _teleportationMaxRadius = entity.TeleportationMaxRadius;
            _transform = entity.Transform;
        }

        public override void Enter()
        {
            base.Enter();

            CalculateMaxDistanceToTarget();
            _teleportationRequest.Invoke(_transform.position + _transform.forward * _distanceToTarget);
        }

        private void CalculateMaxDistanceToTarget()
        {
            Entity target = _entity.CurrentTarget.Value;
            Vector3 direction = target.Transform.position - _transform.position;

            _distanceToTarget = direction.magnitude - DistanceThreshold;

            if (_distanceToTarget > _teleportationMaxRadius.Value)
                _distanceToTarget = _teleportationMaxRadius.Value;
        }

        public void Update(float deltaTime) {}
    }
}
