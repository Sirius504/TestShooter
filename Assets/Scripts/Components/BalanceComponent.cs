using Test.Balance;
using Unity.Entities;

namespace Test.Components
{
	public struct BalanceComponent : IComponentData
	{
		public BlobAssetReference<BalanceBlobAsset> Balance;
	}
}
