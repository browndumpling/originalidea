using UnityEngine;
using System.Collections;

public class MoveAround : MonoBehaviour {

    public float forwardVel = 10F;
    public float sideVel = 5F;
    public float rotVel = 5F;
    private Vector3 moveDirection;
    public float weight;
    public float wDmg;
    public float mDmg;
    public float lookDeadzone = 0f;
    public float sprintMultiplier = 5f;
    private float sSide;
    private float sForward;

    void Start () {

    }
	
	
	void Update () {

	
	}

    void FixedUpdate()
    {
        determineVel();
        Move();
        Rotate();
        if (Input.GetMouseButton(0) == true)
        {
            Attack();
        }

    }

    void Move()
    {
        Rigidbody mPlayer = GetComponent<Rigidbody>();

        if (Input.GetKey("left shift") == true)
        {
            //mPlayer.velocity = Vector3.Normalize(Input.GetAxis("Vertical") * transform.forward * forwardVel + Input.GetAxis("Horizontal") * transform.right * sideVel);
            //mPlayer.velocity = mPlayer.velocity * sprintMultiplier;
            moveDirection = new Vector3(Input.GetAxis("Horizontal") * sideVel, 0, Input.GetAxis("Vertical")*forwardVel);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= sprintMultiplier;
            mPlayer.velocity = moveDirection;

        }
        else
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal")*sideVel, 0, Input.GetAxis("Vertical")*forwardVel);
            moveDirection = transform.TransformDirection(moveDirection);
            mPlayer.velocity = moveDirection;
        }
        
    }

    void Rotate()
    {
        Plane playerPlane = new Plane(Vector3.up, transform.position);
/////// Plane cutPlane = new Plane(Vector3.left, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitdist = 0.0f;
        if (playerPlane.Raycast (ray, out hitdist) && Input.GetMouseButton(1) != true)
        {
            Vector3 targetPoint = ray.GetPoint(hitdist);
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
            //     if (Mathf.Abs(cutPlane.GetDistanceToPoint(targetPoint)) > lookDeadzone)
            //     {
            //         transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotVel * Time.deltaTime);
            //     }
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotVel * Time.deltaTime);

        }
    }

    void Attack()
    {
    }

    void StopAttack()
    {

    }

    void determineVel()
    {

    }

 
    
}
