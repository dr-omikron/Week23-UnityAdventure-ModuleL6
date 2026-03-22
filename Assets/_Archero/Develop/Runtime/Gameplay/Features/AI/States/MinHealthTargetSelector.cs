using System.Collections.Generic;
using System.Linq;
using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Gameplay.Features.ApplyDamage;
using _Archero.Develop.Runtime.Utilities.Conditions;

namespace _Archero.Develop.Runtime.Gameplay.Features.AI.States
{
    public class MinHealthTargetSelector : ITargetSelector
    {
        private readonly Entity _source;

        public MinHealthTargetSelector(Entity entity)
        {
            _source = entity;
        }

        public Entity SelectTargetFrom(IEnumerable<Entity> targets)
        {
            IEnumerable<Entity> selected = targets.Where(target =>
            {
                bool result = target.HasComponent<TakeDamageRequest>();

                if (target.TryGetCanApplyDamage(out ICompositeCondition canApplyDamage))
                    result = result && canApplyDamage.Evaluate();

                result = result && target != _source;

                return result;
            });

            if(selected.Any() == false)
                return null;

            Entity target = selected.First();
            float minHealth = target.CurrentHealth.Value;

            foreach (Entity selectedTarget in selected)
            {
                if (selectedTarget.CurrentHealth.Value < minHealth)
                {
                    minHealth = selectedTarget.CurrentHealth.Value;
                    target = selectedTarget;
                }
            }

            return target;
        }
    }
}
