using System;
using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Gameplay.EntitiesCore.Systems;
using _Archero.Develop.Runtime.Utilities.Reactive;
using UnityEngine;

namespace _Archero.Develop.Runtime.Gameplay.Features.Abilities
{
    public class CalculateStatsPercentsSystem : IInitializableSystem, IUpdateableSystem, IDisposableSystem
    {
        private ReactiveVariable<float> _maxEnergy;
        private ReactiveVariable<float> _currentEnergy;
        private ReactiveVariable<float> _energyPercent;

        private IDisposable _energyPercentChangedDisposable;

        public void OnInit(Entity entity)
        {
            _maxEnergy = entity.MaxEnergy;
            _currentEnergy = entity.CurrentEnergy;
            _energyPercent = entity.EnergyPercent;

            _energyPercentChangedDisposable = _energyPercent.Subscribe(OnEnergyPercentChanged);
        }

        public void OnUpdate(float deltaTime)
        {
            _energyPercent.Value = _currentEnergy.Value / _maxEnergy.Value;
        }

        private void OnEnergyPercentChanged(float arg1, float newValue) => Debug.Log($"EnergyPercent: {newValue}");

        public void OnDispose() => _energyPercentChangedDisposable.Dispose();
    }
}
