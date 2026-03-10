using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Utilities.Conditions;
using _Archero.Develop.Runtime.Utilities.Reactive;

namespace _Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage
{
    public class BodyContactDamage : IEntityComponent
    {
        public ReactiveVariable<float> Value;
    }

    public class AriaContactDamage : IEntityComponent
    {
        public ReactiveVariable<float> Value;
    }

    public class IsActivateAriaDetectingSystem : IEntityComponent
    {
        public ReactiveVariable<bool> Value;
    }

    public class IsDamageDealt  : IEntityComponent
    {
        public ReactiveVariable<bool> Value;
    }

    public class MustCastAriaContactSphere : IEntityComponent
    {
        public ICompositeCondition Value;
    }
}
