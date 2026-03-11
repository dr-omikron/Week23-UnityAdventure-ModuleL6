using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Utilities.Reactive;
using _Archero.Develop.Runtime.Utilities.StateMachineCore;
using UnityEngine;

namespace _Archero.Develop.Runtime.Gameplay.Features.AI.States
{
    public class ForwardDirectionTeleportState : State, IUpdatableState
    {
        private readonly ReactiveEvent _teleported;
        private readonly ReactiveVariable<float> _teleportationMaxRadius;
        private readonly Transform _transform;

        public ForwardDirectionTeleportState(Entity entity)
        {
            _teleportationMaxRadius = entity.TeleportationMaxRadius;
            _transform = entity.Transform;
            _teleported = entity.Teleported;
        }

        public bool IsTeleported { get; private set; }

        public override void Enter()
        {
            base.Enter();

            _transform.position += _transform.forward * _teleportationMaxRadius.Value;
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
