using UnityEngine;

namespace Test.Balance
{
	[CreateAssetMenu(fileName = "PlayerBalance", menuName = "Test/Balance/PlayerBalance")]
	public class Player : ScriptableObject
	{
		public float Speed => speed;
		[SerializeField] private float speed;
	}
}