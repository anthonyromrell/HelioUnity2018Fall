using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TestLetter : MonoBehaviour
{
	public NameID thisId;
	public UnityEvent OnMatch;
	
	void OnTriggerEnter (Collider letterId)
	{
		if (thisId == letterId.GetComponent<HoldLetter>().Id)
		{
			 OnMatch.Invoke();
		}
	}
}