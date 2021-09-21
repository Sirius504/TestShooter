using UnityEngine;

namespace Test.Balance
{
	public class BalanceHolder : MonoBehaviour
	{
		public Balance Balance => balance;

		[SerializeField] private Balance balance;
	}
}
