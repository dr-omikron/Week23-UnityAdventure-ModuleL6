using System;
using System.Collections.Generic;
using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Gameplay.Features.AI.States;
using _Archero.Develop.Runtime.Gameplay.Features.InputFeature;
using _Archero.Develop.Runtime.Infrastructure.DI;
using _Archero.Develop.Runtime.Utilities;
using _Archero.Develop.Runtime.Utilities.Conditions;
using _Archero.Develop.Runtime.Utilities.Reactive;
using _Archero.Develop.Runtime.Utilities.Timer;
using UnityEngine;

namespace _Archero.Develop.Runtime.Gameplay.Features.AI
{
    public class BrainsFactory
    {
        private readonly DIContainer _container;
        private readonly TimerServiceFactory _timerServiceFactory;
        private readonly IInputService _inputService;

        public BrainsFactory(DIContainer container)
        {
            _container = container;
            _timerServiceFactory = _container.Resolve<TimerServiceFactory>();
            _inputService = _container.Resolve<IInputService>();
        }

        public StateMachineBrain CreateMainHeroBrain(Entity entity)
        {
            AIStateMachine combatState = CreatePlayerInputAttackStateMachine(entity);
            PlayerInputMovementState movementState = new PlayerInputMovementState(entity, _inputService);

            ICondition fromMovementToCombatState = new FuncCondition(() => _inputService.AxisDirection == Vector3.zero);
            ICondition fromCombatToMovementState = new FuncCondition(() => _inputService.AxisDirection != Vector3.zero);

            AIStateMachine behaviour = new AIStateMachine();
            
            behaviour.AddState(combatState);
            behaviour.AddState(movementState);

            behaviour.AddTransition(movementState, combatState, fromMovementToCombatState);
            behaviour.AddTransition(combatState, movementState, fromCombatToMovementState);

            StateMachineBrain brain = new StateMachineBrain(behaviour);

            return brain;
        }

        public StateMachineBrain CreateRandomTelepotGhostBrain(Entity entity)
        {
            AIStateMachine stateMachine = CreateRandomTelepotStateMachine(entity);
            StateMachineBrain brain = new StateMachineBrain(stateMachine);

            return brain;
        }

        public StateMachineBrain CreateTelepotToTargetGhostBrain(Entity entity)
        {
            AIStateMachine stateMachine = CreateTelepotToTargetStateMachine(entity);
            StateMachineBrain brain = new StateMachineBrain(stateMachine);

            return brain;
        }

        private AIStateMachine CreateRandomTelepotStateMachine(Entity entity)
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

        private AIStateMachine CreateTelepotToTargetStateMachine(Entity entity)
        {
            List<IDisposable> disposables = new List<IDisposable>();

            RotateToTargetState rotateToTargetState = new RotateToTargetState(entity);
            ForwardDirectionTeleportState forwardDirectionTeleportState = new ForwardDirectionTeleportState(entity);

            TimerService cooldownTimer = _timerServiceFactory.Create(3.0f);

            disposables.Add(cooldownTimer);
            disposables.Add(rotateToTargetState.Entered.Subscribe(cooldownTimer.Restart));

            ICompositeCondition rotateToTeleportCondition = new CompositeCondition()
                .Add(new FuncCondition(() => cooldownTimer.IsOver))
                .Add(new FuncCondition(() => entity.CurrentEnergy.Value >= entity.TeleportationEnergyCost.Value))
                .Add(new FuncCondition(() =>
                {
                    Entity target = entity.CurrentTarget.Value;

                    if (target == null)
                        return false;

                    float angleToTarget = Quaternion.Angle(
                        entity.Transform.rotation, Quaternion.LookRotation(
                            target.Transform.position - entity.Transform.position));

                    return angleToTarget < 3f;
                }));

            FuncCondition teleportEndCondition = new FuncCondition(() => forwardDirectionTeleportState.IsTeleported);

            AIStateMachine stateMachine = new AIStateMachine(disposables);

            stateMachine.AddState(rotateToTargetState);
            stateMachine.AddState(forwardDirectionTeleportState);

            stateMachine.AddTransition(rotateToTargetState, forwardDirectionTeleportState, rotateToTeleportCondition);
            stateMachine.AddTransition(forwardDirectionTeleportState, rotateToTargetState, teleportEndCondition);

            return stateMachine;
        }

        private AIStateMachine CreatePlayerInputAttackStateMachine(Entity entity)
        {
            PlayerInputRotationState playerInputRotationState = new PlayerInputRotationState(entity, _inputService);
            PlayerInputAttackState playerInputAttackState = new PlayerInputAttackState(entity, _inputService);

            ICompositeCondition fromRotateToAttackCondition = new CompositeCondition()
                .Add(new FuncCondition(() => entity.CanStartAttack.Evaluate()))
                .Add(new FuncCondition(() => _inputService.IsFireKeyPressed));

            ReactiveVariable<bool> inAttackProcess = entity.InAttackProcess;
            ICondition fromAttackToRotateCondition = new FuncCondition(() => inAttackProcess.Value == false);

            AIStateMachine stateMachine = new AIStateMachine();
            
            stateMachine.AddState(playerInputRotationState);
            stateMachine.AddState(playerInputAttackState);

            stateMachine.AddTransition(playerInputRotationState, playerInputAttackState, fromRotateToAttackCondition);
            stateMachine.AddTransition(playerInputAttackState, playerInputRotationState, fromAttackToRotateCondition);

            return stateMachine;
        }
    }
}
