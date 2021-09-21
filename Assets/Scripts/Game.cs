using UnityEngine;
using Unity.Entities;

namespace Test
{
	public class Game : MonoBehaviour
	{		
		[SerializeField] private GameObject playerPrefabAsset;
		//[SerializeField] private GameObject camera;

		//[SerializeField] private PlayerInputMovementStrategy playerInputMovementtStrategy;
		//[SerializeField] private PlayerInputTargetStrategy playerInputTargetStrategy;

		//[SerializeField] private GameObject projectilePrefab;
		//private BulletFactory bulletFactory;

		private World world;
		private EntityManager entityManager;
		private GameObjectConversionSettings conversionSettings;

		private Entity player;		

		private void Start()
		{
			world = World.DefaultGameObjectInjectionWorld;
			entityManager = world.EntityManager;
			conversionSettings = GameObjectConversionSettings.FromWorld(world, null);

			
		}
		
		//private void ResolveDependencies()
		//{
		//	ResolvePlayer();
		//	ResolveCamera();
		//}

		//private void ResolveCamera()
		//{
		//	var cameraMovement = camera.GetComponent<MovementBehaviour>();
		//	var directionStrategy = camera.GetComponent<IDirectionStrategy>();
		//	if (directionStrategy == null)
		//	{
		//		var newStrategy = camera.AddComponent<FollowStrategy>();
		//		newStrategy.Target = player;
		//		directionStrategy = newStrategy;
		//	}
		//	cameraMovement.Init(directionStrategy);
		//}

		//private void ResolvePlayer()
		//{
		//	var playerMovement = player.GetComponent<MovementBehaviour>();
		//	var fireBehaviour = player.GetComponent<FireBehaviour>();
		//	playerMovement.Init(playerInputMovementtStrategy);
		//	bulletFactory = new BulletFactory(projectilePrefab);
		//	fireBehaviour.Init(() => bulletFactory.Get(), playerInputTargetStrategy);
		//}
	} 
}
