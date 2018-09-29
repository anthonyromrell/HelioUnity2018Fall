using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

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