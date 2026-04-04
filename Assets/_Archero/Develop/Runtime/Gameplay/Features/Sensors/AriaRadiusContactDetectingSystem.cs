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
        private ReactiveVariable<bool> _isActive;
        private ICompositeCondition _mustCast;
        private Transform _entityTransform;

        public void OnInit(Entity entity)
        {
            _contacts = entity.ContactsCollidersBuffer;
            _layerMask = entity.ContactsDetectingMask;
            _detectingSphere = entity.AriaSphereCollider;
            _isActive = entity.IsActivateAriaDetectingSystem;
            _mustCast = entity.MustCastAriaContactSphere;
            _entityTransform = entity.Transform;
        }

        public void OnUpdate(float deltaTime)
        {
            if(_mustCast.Evaluate() == false)
                return;

            CastOverlapSphere();
            _isActive.Value = false;
        }

        private void CastOverlapSphere()
        {
            _contacts.Count = Physics.OverlapSphereNonAlloc(
                _entityTransform.position,
                _detectingSphere.radius,
                _contacts.Items,
                _layerMask,
                QueryTriggerInteraction.Collide);
        }
    }
}
