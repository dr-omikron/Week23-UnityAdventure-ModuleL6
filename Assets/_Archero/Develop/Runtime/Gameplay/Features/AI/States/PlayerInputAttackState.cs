using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Gameplay.Features.InputFeature;
using _Archero.Develop.Runtime.Utilities.Reactive;
using _Archero.Develop.Runtime.Utilities.StateMachineCore;

namespace _Archero.Develop.Runtime.Gameplay.Features.AI.States
{
    public class PlayerInputAttackState : State, IUpdatableState
    {
        private readonly ReactiveEvent _attackRequest;
        private readonly IInputService _inputService;

        public PlayerInputAttackState(Entity entity, IInputService inputService)
        {
            _inputService = inputService;
            _attackRequest = entity.StartAttackRequest;
        }

        public override void Enter()
        {
            _attackRequest.Invoke();
        }

        public void Update(float deltaTime)
        {
            
        }
    }
}
