using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

    float forwardInput, strafeInput;
    Quaternion targetRotation;
    Rigidbody rBody;
    public float maxVelo = 10;
    private Vector3 strafeMovement;

    void GetInput()
    {
        forwardInput = Input.GetAxis("Vertical");
        strafeInput = Input.GetAxis("Horizontal");
    }

    void Update()
    {
        GetInput();
    }

    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        strafeMovement = new Vector3(strafeInput, 0, forwardInput);
        rBody = GetComponent<Rigidbody>();
        rBody.velocity = strafeMovement * maxVelo;
    }
}
