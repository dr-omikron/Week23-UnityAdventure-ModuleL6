using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Utilities;
using _Archero.Develop.Runtime.Utilities.Reactive;
using _Archero.Develop.Runtime.Utilities.StateMachineCore;
using UnityEngine;

namespace _Archero.Develop.Runtime.Gameplay.Features.AI.States
{
    public class RandomPositionTeleportState : State, IUpdatableState
    {
        private readonly ReactiveEvent _teleported;
        private readonly ReactiveVariable<float> _teleportationMaxRadius;
        private readonly Transform _transform;

        private readonly RandomPointGeneratorService _randomPointGeneratorService;
        private Vector3 _randomPosition;

        public RandomPositionTeleportState(Entity entity, RandomPointGeneratorService randomPointGeneratorService)
        {
            _randomPointGeneratorService = randomPointGeneratorService;
            _teleportationMaxRadius = entity.TeleportationMaxRadius;
            _transform = entity.Transform;
            _teleported = entity.Teleported;
        }

        public bool IsTeleported { get; private set; }

        public override void Enter()
        {
            base.Enter();

            _randomPosition = _randomPointGeneratorService.Generate(_transform, _teleportationMaxRadius.Value);

            _transform.position = _randomPosition;
            _teleported.Invoke();

            IsTeleported = true;
        }

        public void Update(float deltaTime) {}

        public override void Exit()
        {
            base.Exit();

            IsTeleported = false;
        }

    }
}
