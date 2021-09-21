using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

[RequiresEntityConversion]
public class ReferenceAuthoring : MonoBehaviour, IConvertGameObjectToEntity
{
	[SerializeField] private List<GameObject> referenceUsers;

	public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
	{
		foreach (var user in referenceUsers)
		{
			if (user.TryGetComponent(out IEntityReferenceUser referenceUser))
				referenceUser.Entity = entity;
		}
	}
}
