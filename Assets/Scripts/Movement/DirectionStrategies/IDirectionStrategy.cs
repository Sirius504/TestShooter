using UnityEngine;

namespace Test.Movement.Strategies
{
	public interface IDirectionStrategy
	{
		Vector2 GetDirection();
	} 
}