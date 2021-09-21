using Test.Balance;
using Test.Components;
using Unity.Collections;
using Unity.Entities;

namespace Test.Systems
{
	[UpdateInGroup(typeof(GameObjectConversionGroup))]
	public class BalanceConversionSystem : GameObjectConversionSystem
	{
		public static BlobAssetReference<BalanceBlobAsset> BalanceReference;
		protected override void OnUpdate()
		{
			Entities.ForEach((BalanceHolder holder) =>
			{
				using (BlobBuilder blobBuilder = new BlobBuilder(Allocator.Temp))
				{
					ref BalanceBlobAsset npcDataBlobAsset = ref blobBuilder.ConstructRoot<BalanceBlobAsset>();
					npcDataBlobAsset.player = CreatePlayerBlob(holder.Balance.Player);
					BalanceReference = blobBuilder.CreateBlobAssetReference<BalanceBlobAsset>(Allocator.Persistent);
				}

				DstEntityManager.AddComponentData(GetPrimaryEntity(holder), new BalanceComponent
				{
					Balance = BalanceReference
				});
			});
		}

		private static PlayerBlob CreatePlayerBlob(Player playerBalance)
		{
			return new PlayerBlob{ speed = playerBalance.Speed };
		}
	}
}