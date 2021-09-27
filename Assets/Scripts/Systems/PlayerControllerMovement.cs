using Test.Balance;
using Test.Components;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Physics;
using UnityEngine;

[AlwaysSynchronizeSystem]
[UpdateInGroup(typeof(SimulationSystemGroup))]
public class PlayerControllerMovement : JobComponentSystem
{
	protected override JobHandle OnUpdate(JobHandle inputHandle)
	{
		float speed = 0f;
		float deltaTime = Time.DeltaTime;
		Entities.ForEach((ref BalanceComponent balanceComponent) =>
		{
			ref BlobAssetReference<BalanceBlobAsset> balance = ref balanceComponent.Balance;
			speed = balance.Value.player.speed;
		}).Run();
		
		Entities.ForEach((ref PhysicsVelocity velocity, in PlayerControlled playerControlled) =>
		{
			float3 input = float3.zero;
			if (Input.GetKey(KeyCode.A))
				input.x = -1;
			if (Input.GetKey(KeyCode.D))
				input.x = 1;
			if (Input.GetKey(KeyCode.W))
				input.y = 1;
			if (Input.GetKey(KeyCode.S))
				input.y = -1;
			if (!input.Equals(float3.zero))
				input = math.normalize(input);
			velocity.Linear = input * speed * deltaTime;
		}).Run();

		return default;
	}
}