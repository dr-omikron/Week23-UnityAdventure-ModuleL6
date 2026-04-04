using System;
using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Gameplay.EntitiesCore.Systems;
using _Archero.Develop.Runtime.Utilities.Conditions;
using _Archero.Develop.Runtime.Utilities.Reactive;
using UnityEngine;

namespace _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation
{
    public class TeleportationSystem : IInitializableSystem, IDisposableSystem
    {
        private ReactiveEvent _teleported;
        private ReactiveEvent<Vector3> _teleportationRequest;
        private Transform _transform;
        private ICompositeCondition _canTeleport;

        private IDisposable _teleportationRequestDisposable;

        public void OnInit(Entity entity)
        {
            _teleported = entity.Teleported;
            _canTeleport = entity.CanTeleport;
            _transform = entity.Transform;
            _teleportationRequest = entity.TeleportationRequest;

            _teleportationRequestDisposable = _teleportationRequest.Subscribe(OnTeleportationRequest);
        }

        private void OnTeleportationRequest(Vector3 position)
        {
            if (_canTeleport.Evaluate())
            {
                _transform.position = position;
                _teleported.Invoke();
            }
        }

        public void OnDispose() => _teleportationRequestDisposable.Dispose();
    }
}
