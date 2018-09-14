using UnityEngine;
using UnityEngine.Events;

public class EventClass : MonoBehaviour
{
	public UnityEvent Event;

	void OnMouseDown()
	{
		Event.Invoke();
	}

	void OnTriggerEnter()
	{
		Event.Invoke();
	}
}