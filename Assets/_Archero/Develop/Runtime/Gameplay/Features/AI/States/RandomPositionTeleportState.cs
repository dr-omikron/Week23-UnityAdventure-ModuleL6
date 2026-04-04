using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Utilities;
using _Archero.Develop.Runtime.Utilities.Reactive;
using _Archero.Develop.Runtime.Utilities.StateMachineCore;
using UnityEngine;

namespace _Archero.Develop.Runtime.Gameplay.Features.AI.States
{
    public class RandomPositionTeleportState : State, IUpdatableState
    {
        private readonly ReactiveEvent<Vector3> _teleportationRequest;
        private readonly ReactiveVariable<float> _teleportationMaxRadius;
        private readonly Transform _transform;

        private readonly RandomPointGeneratorService _randomPointGeneratorService;
        private Vector3 _randomPosition;

        public RandomPositionTeleportState(Entity entity, RandomPointGeneratorService randomPointGeneratorService)
        {
            _transform = entity.Transform;
            _randomPointGeneratorService = randomPointGeneratorService;
            _teleportationMaxRadius = entity.TeleportationMaxRadius;
            _teleportationRequest = entity.TeleportationRequest;
        }

        public override void Enter()
        {
            base.Enter();

            _randomPosition = _randomPointGeneratorService.Generate(_transform, _teleportationMaxRadius.Value);
            _teleportationRequest.Invoke(_randomPosition);
        }

        public void Update(float deltaTime) {}
    }
}
