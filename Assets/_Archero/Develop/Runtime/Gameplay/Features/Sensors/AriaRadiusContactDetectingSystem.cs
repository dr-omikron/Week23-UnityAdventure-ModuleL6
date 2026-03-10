using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Gameplay.EntitiesCore.Systems;
using _Archero.Develop.Runtime.Utilities;
using _Archero.Develop.Runtime.Utilities.Conditions;
using _Archero.Develop.Runtime.Utilities.Reactive;
using UnityEngine;

namespace _Archero.Develop.Runtime.Gameplay.Features.Sensors
{
    public class AriaRadiusContactDetectingSystem : IInitializableSystem, IUpdateableSystem
    {
        private Buffer<Collider> _contacts;
        private LayerMask _layerMask;
        private SphereCollider _detectingSphere;
        private CapsuleCollider _bodyCollider;
        private ReactiveVariable<bool> _isActive;
        private ICompositeCondition _mustCast;

        private readonly RemoveSelfFromContactsService _removeSelfFromContactsService;

        public AriaRadiusContactDetectingSystem(RemoveSelfFromContactsService removeSelfFromContactsService)
        {
            _removeSelfFromContactsService = removeSelfFromContactsService;
        }

        public void OnInit(Entity entity)
        {
            _contacts = entity.ContactsCollidersBuffer;
            _layerMask = entity.ContactsDetectingMask;
            _detectingSphere = entity.AriaSphereCollider;
            _bodyCollider = entity.BodyCollider;
            _isActive = entity.IsActivateAriaDetectingSystem;
            _mustCast = entity.MustCastAriaContactSphere;
        }

        public void OnUpdate(float deltaTime)
        {
            if(_mustCast.Evaluate() == false)
                return;

            CastOverlapSphere();
            _removeSelfFromContactsService.Remove(_contacts, _bodyCollider);
            _isActive.Value = false;

            Debug.Log("Area sphere detected: " + _contacts.Count);
        }

        private void CastOverlapSphere()
        {
            _contacts.Count = Physics.OverlapSphereNonAlloc(
                _detectingSphere.center,
                _detectingSphere.radius,
                _contacts.Items,
                _layerMask,
                QueryTriggerInteraction.Ignore);
        }
    }
}
