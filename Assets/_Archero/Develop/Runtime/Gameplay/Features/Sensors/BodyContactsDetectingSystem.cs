using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Gameplay.EntitiesCore.Systems;
using _Archero.Develop.Runtime.Utilities;
using UnityEngine;

namespace _Archero.Develop.Runtime.Gameplay.Features.Sensors
{
    public class BodyContactsDetectingSystem : IInitializableSystem, IUpdateableSystem
    {
        private Buffer<Collider> _contacts;
        private LayerMask _layerMask;
        private CapsuleCollider _body;
        
        private readonly RemoveSelfFromContactsService _removeSelfFromContactsService;

        public BodyContactsDetectingSystem(RemoveSelfFromContactsService removeSelfFromContactsService)
        {
            _removeSelfFromContactsService = removeSelfFromContactsService;
        }

        public void OnInit(Entity entity)
        {
            _contacts = entity.ContactsCollidersBuffer;
            _layerMask = entity.ContactsDetectingMask;
            _body = entity.BodyCollider;
        }

        public void OnUpdate(float deltaTime)
        {
            _contacts.Count = Physics.OverlapCapsuleNonAlloc(
                _body.bounds.min, 
                _body.bounds.max, 
                _body.radius, 
                _contacts.Items, 
                _layerMask, 
                QueryTriggerInteraction.Ignore);

            _removeSelfFromContactsService.Remove(_contacts, _body);
        }
    }
}
