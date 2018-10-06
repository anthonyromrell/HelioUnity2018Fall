using ArtisanDream.Experimental.Objects;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Resources.Letters
{
	public class TestID : MonoBehaviour
	{
		public NameID ID;
		public UnityEvent OnMatch;
	
		void OnTriggerEnter (Collider letterId)
		{
			if (ID == letterId.GetComponent<HoldID>().ID)
			{
				OnMatch.Invoke();
			}
		}
	}
}