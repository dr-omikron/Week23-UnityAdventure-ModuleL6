namespace _Archero.Develop.Runtime.Gameplay.EntitiesCore
{
	public partial class Entity
	{
		public _Archero.Develop.Runtime.Gameplay.Features.Sensors.BodyCollider BodyColliderC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Sensors.BodyCollider>();

		public UnityEngine.CapsuleCollider BodyCollider => BodyColliderC.Value;

		public bool TryGetBodyCollider(out UnityEngine.CapsuleCollider value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Sensors.BodyCollider component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.CapsuleCollider);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddBodyCollider(UnityEngine.CapsuleCollider value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Sensors.BodyCollider {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Sensors.AriaSphereCollider AriaSphereColliderC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Sensors.AriaSphereCollider>();

		public UnityEngine.SphereCollider AriaSphereCollider => AriaSphereColliderC.Value;

		public bool TryGetAriaSphereCollider(out UnityEngine.SphereCollider value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Sensors.AriaSphereCollider component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.SphereCollider);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAriaSphereCollider(UnityEngine.SphereCollider value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Sensors.AriaSphereCollider {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Sensors.ContactsDetectingMask ContactsDetectingMaskC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Sensors.ContactsDetectingMask>();

		public UnityEngine.LayerMask ContactsDetectingMask => ContactsDetectingMaskC.Value;

		public bool TryGetContactsDetectingMask(out UnityEngine.LayerMask value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Sensors.ContactsDetectingMask component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.LayerMask);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddContactsDetectingMask(UnityEngine.LayerMask value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Sensors.ContactsDetectingMask {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Sensors.ContactsCollidersBuffer ContactsCollidersBufferC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Sensors.ContactsCollidersBuffer>();

		public _Archero.Develop.Runtime.Utilities.Buffer<UnityEngine.Collider> ContactsCollidersBuffer => ContactsCollidersBufferC.Value;

		public bool TryGetContactsCollidersBuffer(out _Archero.Develop.Runtime.Utilities.Buffer<UnityEngine.Collider> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Sensors.ContactsCollidersBuffer component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Buffer<UnityEngine.Collider>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddContactsCollidersBuffer(_Archero.Develop.Runtime.Utilities.Buffer<UnityEngine.Collider> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Sensors.ContactsCollidersBuffer {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Sensors.ContactsEntitiesBuffer ContactsEntitiesBufferC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Sensors.ContactsEntitiesBuffer>();

		public _Archero.Develop.Runtime.Utilities.Buffer<_Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity> ContactsEntitiesBuffer => ContactsEntitiesBufferC.Value;

		public bool TryGetContactsEntitiesBuffer(out _Archero.Develop.Runtime.Utilities.Buffer<_Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Sensors.ContactsEntitiesBuffer component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Buffer<_Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddContactsEntitiesBuffer(_Archero.Develop.Runtime.Utilities.Buffer<_Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Sensors.ContactsEntitiesBuffer {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Sensors.DeathMask DeathMaskC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Sensors.DeathMask>();

		public UnityEngine.LayerMask DeathMask => DeathMaskC.Value;

		public bool TryGetDeathMask(out UnityEngine.LayerMask value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Sensors.DeathMask component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.LayerMask);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddDeathMask(UnityEngine.LayerMask value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Sensors.DeathMask {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Sensors.IsTouchDeathMask IsTouchDeathMaskC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Sensors.IsTouchDeathMask>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> IsTouchDeathMask => IsTouchDeathMaskC.Value;

		public bool TryGetIsTouchDeathMask(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Sensors.IsTouchDeathMask component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsTouchDeathMask()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Sensors.IsTouchDeathMask { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsTouchDeathMask(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Sensors.IsTouchDeathMask {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.MoveDirection MoveDirectionC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.MovementFeature.MoveDirection>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> MoveDirection => MoveDirectionC.Value;

		public bool TryGetMoveDirection(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.MoveDirection component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddMoveDirection()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.MoveDirection { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddMoveDirection(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.MoveDirection {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.MoveSpeed MoveSpeedC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.MovementFeature.MoveSpeed>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> MoveSpeed => MoveSpeedC.Value;

		public bool TryGetMoveSpeed(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.MoveSpeed component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddMoveSpeed()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.MoveSpeed { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddMoveSpeed(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.MoveSpeed {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.IsMoving IsMovingC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.MovementFeature.IsMoving>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> IsMoving => IsMovingC.Value;

		public bool TryGetIsMoving(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.IsMoving component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsMoving()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.IsMoving { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsMoving(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.IsMoving {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.CanMove CanMoveC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.MovementFeature.CanMove>();

		public _Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition CanMove => CanMoveC.Value;

		public bool TryGetCanMove(out _Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.CanMove component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCanMove(_Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.CanMove {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.RotationDirection RotationDirectionC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.MovementFeature.RotationDirection>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> RotationDirection => RotationDirectionC.Value;

		public bool TryGetRotationDirection(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.RotationDirection component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddRotationDirection()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.RotationDirection { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddRotationDirection(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.RotationDirection {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.RotationSpeed RotationSpeedC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.MovementFeature.RotationSpeed>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> RotationSpeed => RotationSpeedC.Value;

		public bool TryGetRotationSpeed(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.RotationSpeed component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddRotationSpeed()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.RotationSpeed { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddRotationSpeed(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.RotationSpeed {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.CanRotate CanRotateC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.MovementFeature.CanRotate>();

		public _Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition CanRotate => CanRotateC.Value;

		public bool TryGetCanRotate(out _Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.CanRotate component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCanRotate(_Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.MovementFeature.CanRotate {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.CurrentHealth CurrentHealthC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.LifeCycle.CurrentHealth>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> CurrentHealth => CurrentHealthC.Value;

		public bool TryGetCurrentHealth(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.CurrentHealth component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCurrentHealth()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.CurrentHealth { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCurrentHealth(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.CurrentHealth {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.MaxHealth MaxHealthC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.LifeCycle.MaxHealth>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> MaxHealth => MaxHealthC.Value;

		public bool TryGetMaxHealth(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.MaxHealth component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddMaxHealth()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.MaxHealth { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddMaxHealth(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.MaxHealth {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.IsDead IsDeadC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.LifeCycle.IsDead>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> IsDead => IsDeadC.Value;

		public bool TryGetIsDead(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.IsDead component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsDead()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.IsDead { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsDead(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.IsDead {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.MustDie MustDieC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.LifeCycle.MustDie>();

		public _Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition MustDie => MustDieC.Value;

		public bool TryGetMustDie(out _Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.MustDie component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddMustDie(_Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.MustDie {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.MustSelfRelease MustSelfReleaseC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.LifeCycle.MustSelfRelease>();

		public _Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition MustSelfRelease => MustSelfReleaseC.Value;

		public bool TryGetMustSelfRelease(out _Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.MustSelfRelease component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddMustSelfRelease(_Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.MustSelfRelease {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.DeathProcessInitialTime DeathProcessInitialTimeC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.LifeCycle.DeathProcessInitialTime>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> DeathProcessInitialTime => DeathProcessInitialTimeC.Value;

		public bool TryGetDeathProcessInitialTime(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.DeathProcessInitialTime component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddDeathProcessInitialTime()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.DeathProcessInitialTime { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddDeathProcessInitialTime(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.DeathProcessInitialTime {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.DeathProcessCurrentTime DeathProcessCurrentTimeC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.LifeCycle.DeathProcessCurrentTime>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> DeathProcessCurrentTime => DeathProcessCurrentTimeC.Value;

		public bool TryGetDeathProcessCurrentTime(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.DeathProcessCurrentTime component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddDeathProcessCurrentTime()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.DeathProcessCurrentTime { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddDeathProcessCurrentTime(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.DeathProcessCurrentTime {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.InDeathProcess InDeathProcessC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.LifeCycle.InDeathProcess>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> InDeathProcess => InDeathProcessC.Value;

		public bool TryGetInDeathProcess(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.InDeathProcess component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddInDeathProcess()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.InDeathProcess { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddInDeathProcess(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.InDeathProcess {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.DisableCollidersOnDeath DisableCollidersOnDeathC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.LifeCycle.DisableCollidersOnDeath>();

		public System.Collections.Generic.List<UnityEngine.Collider> DisableCollidersOnDeath => DisableCollidersOnDeathC.Value;

		public bool TryGetDisableCollidersOnDeath(out System.Collections.Generic.List<UnityEngine.Collider> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.DisableCollidersOnDeath component);
			if(result)
				value = component.Value;
			else
				value = default(System.Collections.Generic.List<UnityEngine.Collider>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddDisableCollidersOnDeath()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.DisableCollidersOnDeath { Value = new System.Collections.Generic.List<UnityEngine.Collider>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddDisableCollidersOnDeath(System.Collections.Generic.List<UnityEngine.Collider> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.LifeCycle.DisableCollidersOnDeath {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.BodyContactDamage BodyContactDamageC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.BodyContactDamage>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> BodyContactDamage => BodyContactDamageC.Value;

		public bool TryGetBodyContactDamage(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.BodyContactDamage component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddBodyContactDamage()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.BodyContactDamage { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddBodyContactDamage(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.BodyContactDamage {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.AriaContactDamage AriaContactDamageC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.AriaContactDamage>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> AriaContactDamage => AriaContactDamageC.Value;

		public bool TryGetAriaContactDamage(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.AriaContactDamage component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAriaContactDamage()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.AriaContactDamage { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAriaContactDamage(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.AriaContactDamage {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.IsActivateAriaDetectingSystem IsActivateAriaDetectingSystemC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.IsActivateAriaDetectingSystem>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> IsActivateAriaDetectingSystem => IsActivateAriaDetectingSystemC.Value;

		public bool TryGetIsActivateAriaDetectingSystem(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.IsActivateAriaDetectingSystem component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsActivateAriaDetectingSystem()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.IsActivateAriaDetectingSystem { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsActivateAriaDetectingSystem(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.IsActivateAriaDetectingSystem {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.IsDamageDealt IsDamageDealtC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.IsDamageDealt>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> IsDamageDealt => IsDamageDealtC.Value;

		public bool TryGetIsDamageDealt(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.IsDamageDealt component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsDamageDealt()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.IsDamageDealt { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsDamageDealt(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.IsDamageDealt {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.MustCastAriaContactSphere MustCastAriaContactSphereC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.MustCastAriaContactSphere>();

		public _Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition MustCastAriaContactSphere => MustCastAriaContactSphereC.Value;

		public bool TryGetMustCastAriaContactSphere(out _Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.MustCastAriaContactSphere component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddMustCastAriaContactSphere(_Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.ContactTakeDamage.MustCastAriaContactSphere {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Attack.StartAttackRequest StartAttackRequestC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Attack.StartAttackRequest>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent StartAttackRequest => StartAttackRequestC.Value;

		public bool TryGetStartAttackRequest(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Attack.StartAttackRequest component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddStartAttackRequest()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.StartAttackRequest { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddStartAttackRequest(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.StartAttackRequest {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Attack.StartAttackEvent StartAttackEventC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Attack.StartAttackEvent>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent StartAttackEvent => StartAttackEventC.Value;

		public bool TryGetStartAttackEvent(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Attack.StartAttackEvent component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddStartAttackEvent()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.StartAttackEvent { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddStartAttackEvent(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.StartAttackEvent {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Attack.EndAttackEvent EndAttackEventC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Attack.EndAttackEvent>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent EndAttackEvent => EndAttackEventC.Value;

		public bool TryGetEndAttackEvent(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Attack.EndAttackEvent component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddEndAttackEvent()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.EndAttackEvent { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddEndAttackEvent(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.EndAttackEvent {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Attack.CanStartAttack CanStartAttackC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Attack.CanStartAttack>();

		public _Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition CanStartAttack => CanStartAttackC.Value;

		public bool TryGetCanStartAttack(out _Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Attack.CanStartAttack component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCanStartAttack(_Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.CanStartAttack {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackProcessInitialTime AttackProcessInitialTimeC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Attack.AttackProcessInitialTime>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> AttackProcessInitialTime => AttackProcessInitialTimeC.Value;

		public bool TryGetAttackProcessInitialTime(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackProcessInitialTime component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackProcessInitialTime()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackProcessInitialTime { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackProcessInitialTime(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackProcessInitialTime {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackProcessCurrentTime AttackProcessCurrentTimeC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Attack.AttackProcessCurrentTime>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> AttackProcessCurrentTime => AttackProcessCurrentTimeC.Value;

		public bool TryGetAttackProcessCurrentTime(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackProcessCurrentTime component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackProcessCurrentTime()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackProcessCurrentTime { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackProcessCurrentTime(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackProcessCurrentTime {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackDelayTime AttackDelayTimeC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Attack.AttackDelayTime>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> AttackDelayTime => AttackDelayTimeC.Value;

		public bool TryGetAttackDelayTime(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackDelayTime component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackDelayTime()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackDelayTime { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackDelayTime(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackDelayTime {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackDelayEndEvent AttackDelayEndEventC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Attack.AttackDelayEndEvent>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent AttackDelayEndEvent => AttackDelayEndEventC.Value;

		public bool TryGetAttackDelayEndEvent(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackDelayEndEvent component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackDelayEndEvent()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackDelayEndEvent { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackDelayEndEvent(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackDelayEndEvent {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Attack.InAttackProcess InAttackProcessC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Attack.InAttackProcess>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> InAttackProcess => InAttackProcessC.Value;

		public bool TryGetInAttackProcess(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Attack.InAttackProcess component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddInAttackProcess()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.InAttackProcess { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddInAttackProcess(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.InAttackProcess {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Attack.InstantAttackDamage InstantAttackDamageC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Attack.InstantAttackDamage>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> InstantAttackDamage => InstantAttackDamageC.Value;

		public bool TryGetInstantAttackDamage(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Attack.InstantAttackDamage component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddInstantAttackDamage()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.InstantAttackDamage { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddInstantAttackDamage(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.InstantAttackDamage {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Attack.ShootPoint ShootPointC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Attack.ShootPoint>();

		public UnityEngine.Transform ShootPoint => ShootPointC.Value;

		public bool TryGetShootPoint(out UnityEngine.Transform value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Attack.ShootPoint component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.Transform);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddShootPoint(UnityEngine.Transform value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.ShootPoint {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Attack.MustCanceledAttack MustCanceledAttackC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Attack.MustCanceledAttack>();

		public _Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition MustCanceledAttack => MustCanceledAttackC.Value;

		public bool TryGetMustCanceledAttack(out _Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Attack.MustCanceledAttack component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddMustCanceledAttack(_Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.MustCanceledAttack {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackCanceledEvent AttackCanceledEventC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Attack.AttackCanceledEvent>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent AttackCanceledEvent => AttackCanceledEventC.Value;

		public bool TryGetAttackCanceledEvent(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackCanceledEvent component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackCanceledEvent()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackCanceledEvent { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackCanceledEvent(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackCanceledEvent {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownInitialTime AttackCooldownInitialTimeC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownInitialTime>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> AttackCooldownInitialTime => AttackCooldownInitialTimeC.Value;

		public bool TryGetAttackCooldownInitialTime(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownInitialTime component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackCooldownInitialTime()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownInitialTime { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackCooldownInitialTime(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownInitialTime {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownCurrentTime AttackCooldownCurrentTimeC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownCurrentTime>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> AttackCooldownCurrentTime => AttackCooldownCurrentTimeC.Value;

		public bool TryGetAttackCooldownCurrentTime(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownCurrentTime component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackCooldownCurrentTime()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownCurrentTime { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackCooldownCurrentTime(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownCurrentTime {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Attack.InAttackCooldown InAttackCooldownC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Attack.InAttackCooldown>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> InAttackCooldown => InAttackCooldownC.Value;

		public bool TryGetInAttackCooldown(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Attack.InAttackCooldown component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddInAttackCooldown()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.InAttackCooldown { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddInAttackCooldown(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Attack.InAttackCooldown {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.ApplyDamage.TakeDamageRequest TakeDamageRequestC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.ApplyDamage.TakeDamageRequest>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> TakeDamageRequest => TakeDamageRequestC.Value;

		public bool TryGetTakeDamageRequest(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.ApplyDamage.TakeDamageRequest component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddTakeDamageRequest()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.ApplyDamage.TakeDamageRequest { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddTakeDamageRequest(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.ApplyDamage.TakeDamageRequest {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.ApplyDamage.TakeDamageEvent TakeDamageEventC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.ApplyDamage.TakeDamageEvent>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> TakeDamageEvent => TakeDamageEventC.Value;

		public bool TryGetTakeDamageEvent(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.ApplyDamage.TakeDamageEvent component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddTakeDamageEvent()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.ApplyDamage.TakeDamageEvent { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddTakeDamageEvent(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.ApplyDamage.TakeDamageEvent {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.ApplyDamage.CanApplyDamage CanApplyDamageC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.ApplyDamage.CanApplyDamage>();

		public _Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition CanApplyDamage => CanApplyDamageC.Value;

		public bool TryGetCanApplyDamage(out _Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.ApplyDamage.CanApplyDamage component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCanApplyDamage(_Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.ApplyDamage.CanApplyDamage {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.AI.CurrentTarget CurrentTargetC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.AI.CurrentTarget>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<_Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity> CurrentTarget => CurrentTargetC.Value;

		public bool TryGetCurrentTarget(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<_Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.AI.CurrentTarget component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<_Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCurrentTarget()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.AI.CurrentTarget { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<_Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCurrentTarget(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<_Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.AI.CurrentTarget {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Abilities.MaxEnergy MaxEnergyC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Abilities.MaxEnergy>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> MaxEnergy => MaxEnergyC.Value;

		public bool TryGetMaxEnergy(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Abilities.MaxEnergy component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddMaxEnergy()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.MaxEnergy { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddMaxEnergy(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.MaxEnergy {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Abilities.CurrentEnergy CurrentEnergyC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Abilities.CurrentEnergy>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> CurrentEnergy => CurrentEnergyC.Value;

		public bool TryGetCurrentEnergy(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Abilities.CurrentEnergy component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCurrentEnergy()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.CurrentEnergy { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCurrentEnergy(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.CurrentEnergy {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergyPerTimeReductionPercent EnergyPerTimeReductionPercentC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergyPerTimeReductionPercent>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> EnergyPerTimeReductionPercent => EnergyPerTimeReductionPercentC.Value;

		public bool TryGetEnergyPerTimeReductionPercent(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergyPerTimeReductionPercent component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddEnergyPerTimeReductionPercent()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergyPerTimeReductionPercent { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddEnergyPerTimeReductionPercent(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergyPerTimeReductionPercent {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergyReductionPeriodSeconds EnergyReductionPeriodSecondsC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergyReductionPeriodSeconds>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> EnergyReductionPeriodSeconds => EnergyReductionPeriodSecondsC.Value;

		public bool TryGetEnergyReductionPeriodSeconds(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergyReductionPeriodSeconds component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddEnergyReductionPeriodSeconds()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergyReductionPeriodSeconds { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddEnergyReductionPeriodSeconds(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergyReductionPeriodSeconds {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Abilities.CurrentEnergyReductionTime CurrentEnergyReductionTimeC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Abilities.CurrentEnergyReductionTime>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> CurrentEnergyReductionTime => CurrentEnergyReductionTimeC.Value;

		public bool TryGetCurrentEnergyReductionTime(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Abilities.CurrentEnergyReductionTime component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCurrentEnergyReductionTime()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.CurrentEnergyReductionTime { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCurrentEnergyReductionTime(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.CurrentEnergyReductionTime {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergyReductionEvent EnergyReductionEventC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergyReductionEvent>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> EnergyReductionEvent => EnergyReductionEventC.Value;

		public bool TryGetEnergyReductionEvent(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergyReductionEvent component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddEnergyReductionEvent()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergyReductionEvent { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddEnergyReductionEvent(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergyReductionEvent {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Abilities.CanReductionEnergy CanReductionEnergyC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Abilities.CanReductionEnergy>();

		public _Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition CanReductionEnergy => CanReductionEnergyC.Value;

		public bool TryGetCanReductionEnergy(out _Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Abilities.CanReductionEnergy component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCanReductionEnergy(_Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.CanReductionEnergy {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergySpendRequest EnergySpendRequestC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergySpendRequest>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> EnergySpendRequest => EnergySpendRequestC.Value;

		public bool TryGetEnergySpendRequest(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergySpendRequest component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddEnergySpendRequest()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergySpendRequest { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddEnergySpendRequest(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergySpendRequest {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergySpendEvent EnergySpendEventC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergySpendEvent>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> EnergySpendEvent => EnergySpendEventC.Value;

		public bool TryGetEnergySpendEvent(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergySpendEvent component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddEnergySpendEvent()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergySpendEvent { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddEnergySpendEvent(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.EnergySpendEvent {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.CanTeleport CanTeleportC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.CanTeleport>();

		public _Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition CanTeleport => CanTeleportC.Value;

		public bool TryGetCanTeleport(out _Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.CanTeleport component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCanTeleport(_Archero.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.CanTeleport {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.TeleportationMaxRadius TeleportationMaxRadiusC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.TeleportationMaxRadius>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> TeleportationMaxRadius => TeleportationMaxRadiusC.Value;

		public bool TryGetTeleportationMaxRadius(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.TeleportationMaxRadius component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddTeleportationMaxRadius()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.TeleportationMaxRadius { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddTeleportationMaxRadius(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.TeleportationMaxRadius {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.IsActivateTeleport IsActivateTeleportC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.IsActivateTeleport>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> IsActivateTeleport => IsActivateTeleportC.Value;

		public bool TryGetIsActivateTeleport(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.IsActivateTeleport component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsActivateTeleport()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.IsActivateTeleport { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsActivateTeleport(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.IsActivateTeleport {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.TeleportationEnergyCost TeleportationEnergyCostC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.TeleportationEnergyCost>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> TeleportationEnergyCost => TeleportationEnergyCostC.Value;

		public bool TryGetTeleportationEnergyCost(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.TeleportationEnergyCost component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddTeleportationEnergyCost()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.TeleportationEnergyCost { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddTeleportationEnergyCost(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.TeleportationEnergyCost {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.Teleported TeleportedC => GetComponent<_Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.Teleported>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent Teleported => TeleportedC.Value;

		public bool TryGetTeleported(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.Teleported component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddTeleported()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.Teleported { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddTeleported(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Features.Abilities.Teleportation.Teleported {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Common.RigidbodyComponent RigidbodyC => GetComponent<_Archero.Develop.Runtime.Gameplay.Common.RigidbodyComponent>();

		public UnityEngine.Rigidbody Rigidbody => RigidbodyC.Value;

		public bool TryGetRigidbody(out UnityEngine.Rigidbody value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Common.RigidbodyComponent component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.Rigidbody);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddRigidbody(UnityEngine.Rigidbody value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Common.RigidbodyComponent {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Common.TransformComponent TransformC => GetComponent<_Archero.Develop.Runtime.Gameplay.Common.TransformComponent>();

		public UnityEngine.Transform Transform => TransformC.Value;

		public bool TryGetTransform(out UnityEngine.Transform value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Common.TransformComponent component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.Transform);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddTransform(UnityEngine.Transform value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Common.TransformComponent {Value = value});
		}

		public _Archero.Develop.Runtime.Gameplay.Common.NameComponent NameC => GetComponent<_Archero.Develop.Runtime.Gameplay.Common.NameComponent>();

		public _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.String> Name => NameC.Value;

		public bool TryGetName(out _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.String> value)
		{
			bool result = TryGetComponent(out _Archero.Develop.Runtime.Gameplay.Common.NameComponent component);
			if(result)
				value = component.Value;
			else
				value = default(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.String>);
			return result;
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddName()
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Common.NameComponent { Value = new _Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.String>() });
		}

		public _Archero.Develop.Runtime.Gameplay.EntitiesCore.Entity AddName(_Archero.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.String> value)
		{
			return AddComponent(new _Archero.Develop.Runtime.Gameplay.Common.NameComponent {Value = value});
		}

	}
}
