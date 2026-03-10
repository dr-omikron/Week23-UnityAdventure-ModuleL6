using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Utilities.Conditions;
using _Archero.Develop.Runtime.Utilities.Reactive;

namespace _Archero.Develop.Runtime.Gameplay.Features.Abilities
{
    public class MaxEnergy : IEntityComponent
    {
        public ReactiveVariable<float> Value;
    }

    public class CurrentEnergy : IEntityComponent
    {
        public ReactiveVariable<float> Value;
    }

    public class EnergyPerTimeReductionPercent : IEntityComponent
    {
        public ReactiveVariable<float> Value;
    }

    public class EnergyReductionPeriodSeconds : IEntityComponent
    {
        public ReactiveVariable<float> Value;
    }

    public class CurrentEnergyReductionTime : IEntityComponent
    {
        public ReactiveVariable<float> Value;
    }

    public class EnergyReductionEvent : IEntityComponent
    {
        public ReactiveEvent<float> Value;
    }

    public class CanReductionEnergy : IEntityComponent
    {
        public ICompositeCondition Value;
    }

    public class EnergySpendRequest : IEntityComponent
    {
        public ReactiveEvent<float> Value;
    }

    public class EnergySpendEvent : IEntityComponent
    {
        public ReactiveEvent<float> Value;
    }
}
