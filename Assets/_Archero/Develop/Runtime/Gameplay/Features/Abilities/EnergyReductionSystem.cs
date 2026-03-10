using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Gameplay.EntitiesCore.Systems;
using _Archero.Develop.Runtime.Utilities.Conditions;
using _Archero.Develop.Runtime.Utilities.Reactive;
using UnityEngine;

namespace _Archero.Develop.Runtime.Gameplay.Features.Abilities
{
    public class EnergyReductionSystem : IInitializableSystem, IUpdateableSystem
    {
        private ReactiveEvent<float> _reductionEvent;
        private ReactiveVariable<float> _currentEnergy;
        private ReactiveVariable<float> _maxEnergy;
        private ReactiveVariable<float> _reductionPercentage;
        private ReactiveVariable<float> _timePeriod;
        private ReactiveVariable<float> _currentTime;

        private ICompositeCondition _canReduction;
        
        private float _reductionValue;

        public void OnInit(Entity entity)
        {
            _canReduction = entity.CanReductionEnergy;
            _reductionEvent = entity.EnergyReductionEvent;
            _currentEnergy = entity.CurrentEnergy;
            _maxEnergy = entity.MaxEnergy;
            _reductionPercentage = entity.EnergyPerTimeReductionPercent;
            _timePeriod = entity.EnergyReductionPeriodSeconds;
            _currentTime = entity.CurrentEnergyReductionTime;

            _reductionValue = _maxEnergy.Value / _reductionPercentage.Value;
        }

        public void OnUpdate(float deltaTime)
        {
            if (_canReduction.Evaluate() == false)
            {
                ResetCurrentTime();
                return;
            }

            _currentTime.Value += deltaTime;

            if (_currentTime.Value >= _timePeriod.Value)
            {
                _currentEnergy.Value += _reductionValue;
                ResetCurrentTime();
                _reductionEvent.Invoke(_reductionValue);

                Debug.Log($"Reduction energy: {_reductionValue}, current energy: {_currentEnergy.Value}");
            }
        }
        
        private void ResetCurrentTime() => _currentTime.Value = 0;
    }
}
