using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public class FollowEntity : MonoBehaviour, IEntityReferenceUser
{
	public Entity Entity { get; set; }

	private float zOffset;
	private EntityManager entityManager;

	private void Start()
	{
		entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
		zOffset = transform.position.z - GetEntityPosition().z;
	}

	// Update is called once per frame
	void Update()
    {
		float3 entityPosition = GetEntityPosition();
		transform.position = new Vector3(entityPosition.x, entityPosition.y, zOffset);
	}
	private float3 GetEntityPosition()
	{
		return entityManager.GetComponentData<Translation>(Entity).Value;
	}
}
