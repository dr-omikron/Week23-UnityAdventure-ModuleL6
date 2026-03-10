using System;
using System.Collections.Generic;
using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Gameplay.Features.AI.States;
using _Archero.Develop.Runtime.Infrastructure.DI;
using _Archero.Develop.Runtime.Utilities;
using _Archero.Develop.Runtime.Utilities.Conditions;
using _Archero.Develop.Runtime.Utilities.Timer;

namespace _Archero.Develop.Runtime.Gameplay.Features.AI
{
    public class BrainsFactory
    {
        private readonly DIContainer _container;
        private readonly TimerServiceFactory _timerServiceFactory;

        public BrainsFactory(DIContainer container)
        {
            _container = container;
            _timerServiceFactory = _container.Resolve<TimerServiceFactory>();
        }

        public StateMachineBrain CreateRandomTelepotGhostBrain(Entity entity)
        {
            AIStateMachine stateMachine = CreateAIStateMachine(entity);
            StateMachineBrain brain = new StateMachineBrain(stateMachine);

            return brain;
        }

        private AIStateMachine CreateAIStateMachine(Entity entity)
        {
            List<IDisposable> disposables = new List<IDisposable>();

            RandomPositionTeleportState randomPositionTeleportState
                = new RandomPositionTeleportState(entity, _container.Resolve<RandomPointGeneratorService>());

            EmptyState emptyState = new EmptyState();

            TimerService cooldownTimer = _timerServiceFactory.Create(3.0f);

            disposables.Add(cooldownTimer);
            disposables.Add(emptyState.Entered.Subscribe(cooldownTimer.Restart));

            ICompositeCondition emptyToTeleportCondition = new CompositeCondition()
                .Add(new FuncCondition(() => cooldownTimer.IsOver))
                .Add(new FuncCondition(() => entity.CurrentEnergy.Value >= entity.TeleportationEnergyCost.Value));

            FuncCondition teleportEndCondition = new FuncCondition(() => randomPositionTeleportState.IsTeleported);

            AIStateMachine stateMachine = new AIStateMachine(disposables);

            stateMachine.AddState(randomPositionTeleportState);
            stateMachine.AddState(emptyState);

            stateMachine.AddTransition(emptyState, randomPositionTeleportState, emptyToTeleportCondition);
            stateMachine.AddTransition(randomPositionTeleportState, emptyState, teleportEndCondition);

            return stateMachine;
        }
    }
}
