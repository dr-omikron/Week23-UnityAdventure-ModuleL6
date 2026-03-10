using System;
using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Gameplay.EntitiesCore.Systems;
using _Archero.Develop.Runtime.Utilities.Conditions;
using _Archero.Develop.Runtime.Utilities.Reactive;
using UnityEngine;

namespace _Archero.Develop.Runtime.Gameplay.Features.Abilities
{
    public class EnergySpendSystem : IInitializableSystem, IDisposable
    {
        private ReactiveEvent<float> _spendRequest;
        private ReactiveEvent<float> _spendEvent;
        private ReactiveVariable<float> _currentEnergy;
        private ICompositeCondition _canTeleport;

        private IDisposable _requestDisposable;

        public void OnInit(Entity entity)
        {
            _spendRequest = entity.EnergySpendRequest;
            _spendEvent = entity.EnergySpendEvent;
            _currentEnergy = entity.CurrentEnergy;
            _canTeleport = entity.CanTeleport;

            _requestDisposable = _spendRequest.Subscribe(OnSpendRequest);
        }

        public void Dispose()
        {
            _requestDisposable?.Dispose();
        }

        private void OnSpendRequest(float spendValue)
        {
            if (_canTeleport.Evaluate())
            {
                _currentEnergy.Value -= spendValue;
                _spendEvent.Invoke(spendValue);
                
                Debug.Log($"Spent energy: {spendValue}, current energy: {_currentEnergy.Value}");
            }
        }
    }
}
