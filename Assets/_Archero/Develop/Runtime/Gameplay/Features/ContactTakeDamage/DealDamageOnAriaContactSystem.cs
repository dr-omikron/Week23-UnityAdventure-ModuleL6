using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Gameplay.EntitiesCore.Systems;
using _Archero.Develop.Runtime.Gameplay.Features.ApplyDamage;
using _Archero.Develop.Runtime.Utilities;
using _Archero.Develop.Runtime.Utilities.Reactive;
using UnityEngine;

namespace _Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage
{
    public class DealDamageOnAriaContactSystem : IInitializableSystem, IUpdateableSystem
    {
        private Buffer<Entity> _contacts;
        private ReactiveVariable<float> _damage;
        private ReactiveVariable<bool> _isDamageDealt;

        public void OnInit(Entity entity)
        {
            _contacts = entity.ContactsEntitiesBuffer;
            _damage = entity.AriaContactDamage;
            _isDamageDealt = entity.IsDamageDealt;
        }

        public void OnUpdate(float deltaTime)
        {
            if (_isDamageDealt.Value)
                return;

            for (int i = 0; i < _contacts.Count; i++)
            {
                Entity contactEntity = _contacts.Items[i];

                if(contactEntity.HasComponent<TakeDamageRequest>())
                    contactEntity.TakeDamageRequest.Invoke(_damage.Value);
            }

            _isDamageDealt.Value = true;
        }
    }
}
