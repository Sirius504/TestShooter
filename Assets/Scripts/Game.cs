using System;
using UnityEngine;
using Test.Movement;
using Test.Movement.DirectionStrategies;

namespace Test
{
	public class Game : MonoBehaviour
	{		
		[SerializeField] private GameObject player;
		[SerializeField] private PlayerInputStrategy playerInputStrategy;

		private void Awake()
		{
			ResolveDependencies();
		}

		private void ResolveDependencies()
		{
			var playerMovement = player.GetComponent<MovementBehaviour>();
			playerMovement.Init(playerInputStrategy);
		}
	} 
}
