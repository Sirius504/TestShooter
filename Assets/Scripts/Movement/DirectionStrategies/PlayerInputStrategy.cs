using Test.Movement.Strategies;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Test.Movement.DirectionStrategies
{
	class PlayerInputStrategy : MonoBehaviour, IDirectionStrategy
	{
		private Vector2 input; 

		public Vector2 GetDirection()
		{
			return input;
		}

		public void OnMove(InputAction.CallbackContext context)
		{
			input = context.ReadValue<Vector2>();
		}
	}
}
