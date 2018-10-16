using ArtisanDream.Experimental.Objects;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Resources.Letters
{
	public class TestId : MonoBehaviour
	{
		public NameId Id;
		public UnityEvent OnMatch;
	
		void OnTriggerEnter (Collider letterId)
		{
			if (Id == letterId.GetComponent<HoldId>().Id)
			{
				OnMatch.Invoke();
			}
		}
	}
}