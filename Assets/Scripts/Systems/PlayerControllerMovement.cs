using Test.Balance;
using Test.Components;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

public class PlayerControllerMovement : SystemBase
{
	protected override void OnUpdate()
	{
		float speed = 0f;
		Entities.ForEach((ref BalanceComponent balanceComponent) =>
		{
			ref BlobAssetReference<BalanceBlobAsset> balance = ref balanceComponent.Balance;
			speed = balance.Value.player.speed;
		}).Run();
		
		Entities.ForEach((ref Velocity velocity, in PlayerControlled playerControlled) =>
		{
			float2 input = float2.zero;
			if (Input.GetKey(KeyCode.A))
				input.x = -1;
			if (Input.GetKey(KeyCode.D))
				input.x = 1;
			if (Input.GetKey(KeyCode.W))
				input.y = 1;
			if (Input.GetKey(KeyCode.S))
				input.y = -1;
			velocity.Value = input * speed;
		}).Run();
	}
}