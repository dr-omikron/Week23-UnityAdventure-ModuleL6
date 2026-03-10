using _Archero.Develop.Runtime.Gameplay.EntitiesCore;
using _Archero.Develop.Runtime.Gameplay.Features.AI;
using _Archero.Develop.Runtime.Infrastructure.DI;
using UnityEngine;

namespace _Archero.Develop.Runtime.Gameplay
{
    public class TestGameplay : MonoBehaviour
    {
        private DIContainer _container;
        private EntitiesFactory _entitiesFactory;

        private AIBrainContext _brainContext;
        private BrainsFactory _brainsFactory;

        private Entity _entity;
        private Entity _teleportedGhost;
        private bool _isRunning;

        public void Initialize(DIContainer container)
        {
            _container = container;
            _entitiesFactory = _container.Resolve<EntitiesFactory>();
            _brainContext = _container.Resolve<AIBrainContext>();
            _brainsFactory = _container.Resolve<BrainsFactory>();
        }

        public void Run()
        {
            _entity = _entitiesFactory.CreateHero(Vector3.zero);
            _entitiesFactory.CreateGhost(Vector3.zero + Vector3.forward * 3);
            _teleportedGhost = _entitiesFactory.CreateTeleportedGhost(Vector3.zero + Vector3.forward * 1.5f);

            _isRunning = true;
        }

        private void Update()
        {
            if (_isRunning == false)
                return;

            if(Input.GetKeyDown(KeyCode.R))
                _entity.StartAttackRequest.Invoke();

            if(Input.GetKeyDown(KeyCode.Space))
            {
                StateMachineBrain brain = _brainsFactory.CreateRandomTelepotGhostBrain(_teleportedGhost);
                _brainContext.SetFor(_teleportedGhost, brain);
            }

            Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

            _entity.MoveDirection.Value = input;
            _entity.RotationDirection.Value = input;
        }
    }
}
