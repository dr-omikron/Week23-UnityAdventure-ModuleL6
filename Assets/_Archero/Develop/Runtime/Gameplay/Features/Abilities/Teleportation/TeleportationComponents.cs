using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Utilities.Conditions;
using _Archero.Develop.Runtime.Utilities.Reactive;
using UnityEngine;

namespace _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation
{
    public class CanTeleport : IEntityComponent
    {
        public ICompositeCondition Value;
    }

    public class TeleportationMaxRadius : IEntityComponent
    {
        public ReactiveVariable<float> Value;
    }

    public class IsActivateTeleport : IEntityComponent
    {
        public ReactiveVariable<bool> Value;
    }

    public class TeleportationEnergyCost : IEntityComponent
    {
        public ReactiveVariable<float> Value;
    }

    public class Teleported : IEntityComponent
    {
        public ReactiveEvent Value;
    }

    public class TeleportationRequest : IEntityComponent
    {
        public ReactiveEvent<Vector3> Value;
    }
}
