using System;
using Unity.Entities;
using Unity.Mathematics;

namespace Test.Components
{
	[Serializable]
	[GenerateAuthoringComponent]
	public struct Velocity : IComponentData
	{
		public float2 Value;
	}
}
