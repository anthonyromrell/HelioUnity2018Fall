using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 position;
    private Vector3 rotation;
    public float Speed = 3.0f;
    private float JumpSpeed = 4.0f;
    public float Gravity = 9.81f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            position.Set(Speed * Input.GetAxis("Vertical"), 0, 0);
            rotation.Set(0, Input.GetAxis("Horizontal"), 0);
            transform.Rotate(rotation);
            position = transform.TransformDirection(position);

            if (Input.GetButton("Jump"))
            {
                position.y = JumpSpeed;
            }
        }

        position.y -= Gravity * Time.deltaTime;
        
        controller.Move(position * Time.deltaTime);
    }
}