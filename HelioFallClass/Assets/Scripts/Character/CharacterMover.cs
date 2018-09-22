using UnityEngine;

public class CharacterMover : MonoBehaviour
{

	public CharacterController Controller;
	private Vector3 position;
	private Vector3 rotation;
	public float Speed = 3.0f;
	public float Gravity = 9.81f;
	private float JumpSpeed = 4.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Controller.isGrounded)
		{
			position.Set(Speed*Input.GetAxis("Vertical"),0,0);
			rotation.Set(0,Input.GetAxis("Horizontal"),0);
			transform.Rotate(rotation);
			position = transform.TransformDirection(position);

			if (Input.GetButton("Jump"))
			{
				position.y = JumpSpeed;
			}
		}

		position.y -= Gravity*Time.deltaTime;
		
		Controller.Move(position*Time.deltaTime);
	}
}
