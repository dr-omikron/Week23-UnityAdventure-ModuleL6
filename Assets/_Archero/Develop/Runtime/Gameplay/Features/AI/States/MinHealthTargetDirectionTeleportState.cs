using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Utilities.Reactive;
using _Archero.Develop.Runtime.Utilities.StateMachineCore;
using UnityEngine;

namespace _Archero.Develop.Runtime.Gameplay.Features.AI.States
{
    public class MinHealthTargetDirectionTeleportState : State, IUpdatableState
    {
        private readonly ReactiveEvent _teleported;
        private readonly ReactiveVariable<float> _teleportationMaxRadius;
        private readonly Transform _transform;

        public MinHealthTargetDirectionTeleportState(Entity entity)
        {
            _teleportationMaxRadius = entity.TeleportationMaxRadius;
            _transform = entity.Transform;
            _teleported = entity.Teleported;
        }

        public void Update(float deltaTime)
        {
            
        }
    }
}
