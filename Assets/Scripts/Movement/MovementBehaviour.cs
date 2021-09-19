using Test.Movement.Strategies;
using UnityEngine;

namespace Test.Movement
{
	public class MovementBehaviour : MonoBehaviour
	{
		[SerializeField] private float speed;
		private IDirectionStrategy directionStrategy;

		public void Init(IDirectionStrategy directionStrategy)
		{
			this.directionStrategy = directionStrategy;
		}

		// Update is called once per frame
		void Update()
		{
			Vector3 dir = directionStrategy.GetDirection();
			dir.z = transform.position.z;
			transform.position += dir * speed * Time.deltaTime;
		}
	} 
}
