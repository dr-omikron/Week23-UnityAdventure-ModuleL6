using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Gameplay.EntitiesCore.Systems;
using _Archero.Develop.Runtime.Utilities;
using _Archero.Develop.Runtime.Utilities.Conditions;
using _Archero.Develop.Runtime.Utilities.Reactive;
using UnityEngine;

namespace _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation
{
    public class TeleportationSystem : IInitializableSystem, IUpdateableSystem
    {
        private ReactiveEvent _teleported;
        private ReactiveVariable<float> _teleportationMaxRadius;
        private ReactiveVariable<bool> _isActivated;
        private Transform _transform;

        private ICompositeCondition _canTeleport;
        private Vector3 _position;

        private readonly RandomPointGeneratorService _randomPointGeneratorService;
        public TeleportationSystem(RandomPointGeneratorService randomPointGeneratorService)
        {
            _randomPointGeneratorService = randomPointGeneratorService;
        }

        public void OnInit(Entity entity)
        {
            _teleported = entity.Teleported;

            _isActivated = entity.IsActivateTeleport;
            _canTeleport = entity.CanTeleport;

            _transform = entity.Transform;
            _teleportationMaxRadius = entity.TeleportationMaxRadius;
        }

        public void OnUpdate(float deltaTime)
        {
            if(_isActivated.Value == false)
                return;

            if (_canTeleport.Evaluate())
            {
                _position = _randomPointGeneratorService.Generate(
                    _transform, 
                    _teleportationMaxRadius.Value);

                _transform.position = _position;

                _teleported.Invoke();
            }

            _isActivated.Value = false;
        }
    }
}
