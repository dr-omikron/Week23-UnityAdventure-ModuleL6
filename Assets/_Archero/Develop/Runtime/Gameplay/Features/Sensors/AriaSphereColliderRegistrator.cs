using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Gameplay.EntitiesCore.Mono;
using UnityEngine;

namespace _Archero.Develop.Runtime.Gameplay.Features.Sensors
{
    public class AriaSphereColliderRegistrator : MonoEntityRegistrator
    {
        [SerializeField] private SphereCollider _sphereCollider;
        public override void Register(Entity entity)
        {
            entity.AddAriaSphereCollider(_sphereCollider);
        }
    }
}
