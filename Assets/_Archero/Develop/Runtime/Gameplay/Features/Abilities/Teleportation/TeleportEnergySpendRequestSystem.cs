using System;
using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Gameplay.EntitiesCore.Systems;
using _Archero.Develop.Runtime.Utilities.Reactive;

namespace _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation
{
    public class TeleportEnergySpendRequestSystem : IInitializableSystem, IDisposableSystem
    {
        private ReactiveEvent _teleported;
        private ReactiveEvent<float> _energySpendRequest;
        private ReactiveVariable<float> _energySpendCost;
        
        private IDisposable _teleportedDisposable;

        public void OnInit(Entity entity)
        {
            _teleported = entity.Teleported;
            _energySpendRequest = entity.EnergySpendRequest;
            _energySpendCost = entity.TeleportationEnergyCost;

            _teleportedDisposable = _teleported.Subscribe(OnTeleported);
        }

        public void OnDispose()
        {
            _teleportedDisposable.Dispose();
        }

        private void OnTeleported()
        {
            _energySpendRequest.Invoke(_energySpendCost.Value);
        }

    }
}
