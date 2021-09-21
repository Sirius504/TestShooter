using UnityEngine;

namespace Test.Balance
{
	[CreateAssetMenu(fileName = "Balance", menuName = "Test/Balance/Balance")]
	public class Balance : ScriptableObject
	{
		public Player Player => player;
		[SerializeField] private Player player;
	} 
}
