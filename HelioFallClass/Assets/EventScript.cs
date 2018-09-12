using UnityEngine;
using UnityEngine.Events;

public class EventScript : MonoBehaviour
{
	public UnityEvent Event;
	private bool OnButton;

	private void OnMouseDown()
	{
		if (!OnButton) return;
			Event.Invoke();
	}
}