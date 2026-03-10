using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Utilities;
using _Archero.Develop.Runtime.Utilities.Reactive;
using _Archero.Develop.Runtime.Utilities.StateMachineCore;
using UnityEngine;

namespace _Archero.Develop.Runtime.Gameplay.Features.AI.States
{
    public class RandomPositionTeleportState : State
    {
        private readonly ReactiveEvent<float> _energySpendRequest;
        private readonly ReactiveVariable<float> _energySpendCost;
        private readonly ReactiveVariable<float> _teleportationMaxRadius;
        private readonly ReactiveVariable<bool> _isActivateAriaDetectingSystem;
        private readonly ReactiveVariable<bool> _isDamageDealt;
        private readonly Transform _transform;

        private readonly RandomPointGeneratorService _randomPointGeneratorService;
        private Vector3 _randomPosition;

        public RandomPositionTeleportState(Entity entity, RandomPointGeneratorService randomPointGeneratorService)
        {
            _randomPointGeneratorService = randomPointGeneratorService;
            _energySpendRequest = entity.EnergySpendRequest;
            _energySpendCost = entity.TeleportationEnergyCost;
            _teleportationMaxRadius = entity.TeleportationMaxRadius;
            _isActivateAriaDetectingSystem = entity.IsActivateAriaDetectingSystem;
            _isDamageDealt = entity.IsDamageDealt;
            _transform = entity.Transform;
        }

        public bool IsTeleported { get; private set; }

        public override void Enter()
        {
            base.Enter();

            _randomPosition = _randomPointGeneratorService.Generate(_transform, _teleportationMaxRadius.Value);

            _transform.position = _randomPosition;
            _energySpendRequest.Invoke(_energySpendCost.Value);

            IsTeleported = true;
        }

        public override void Exit()
        {
            base.Exit();

            _isActivateAriaDetectingSystem.Value = true;
            _isDamageDealt.Value = false;
            IsTeleported = false;
        }
    }
}
