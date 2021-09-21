using Test.Components;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;

namespace Test.Systems
{
	public class MovementSystem : SystemBase
	{
		protected override void OnUpdate()
		{
			float deltaTime = Time.DeltaTime;
			Entities.ForEach((ref Translation translation, in Velocity velocity) =>
			{
				translation.Value += new float3(velocity.Value.x, velocity.Value.y, 0f) * deltaTime;
			}).Schedule();
		}
	} 
}
