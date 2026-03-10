using System;
using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Gameplay.EntitiesCore.Systems;
using _Archero.Develop.Runtime.Utilities.Reactive;

namespace _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation
{
    public class TeleportAriaDamageRequestSystem : IInitializableSystem, IDisposableSystem
    {
        private ReactiveEvent _teleported;
        private ReactiveVariable<bool> _isActivateAriaDetectingSystem;
        private ReactiveVariable<bool> _isDamageDealt;

        private IDisposable _teleportedDisposable;

        public void OnInit(Entity entity)
        {
            _teleported = entity.Teleported;
            _isActivateAriaDetectingSystem = entity.IsActivateAriaDetectingSystem;
            _isDamageDealt = entity.IsDamageDealt;

            _teleportedDisposable = _teleported.Subscribe(OnTeleported);
        }

        private void OnTeleported()
        {
            _isActivateAriaDetectingSystem.Value = true;
            _isDamageDealt.Value = false;
        }

        public void OnDispose()
        {
            _teleportedDisposable.Dispose();
        }
    }
}
