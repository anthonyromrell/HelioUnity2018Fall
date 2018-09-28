using UnityEngine;

public class Draggable : MonoBehaviour
{
	private Vector3 myPosition;
	private Vector3 previousPosition;

	private void OnMouseDown()
	{
		previousPosition = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
	}

	void OnMouseDrag ()
	{
		myPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) + previousPosition;
		myPosition.z = 0;
		transform.position = myPosition;
	}
}