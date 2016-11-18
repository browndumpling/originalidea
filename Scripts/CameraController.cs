using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public float panVel;
    public Transform pTransform;
    public Vector3 offset;
    private Vector3 camPos;
    public float zoomSpeed = 1;
    private int closestCam = 5;
    private int furthestCam = 25;
    private Vector3 targetPos;
    private Vector3 tempPos;


    void Start()
    {
        camPos = new Vector3(pTransform.position.x, pTransform.position.y + offset.y, pTransform.position.z + offset.z);
    }

    void Update()
    {

        if (Input.GetMouseButton(1) == true)
        {
            camRotatorMouse();

        }
        if(Input.GetAxis("HorizontalCam") != 0)
        {
            camRotatorKeyboard();
        }
        else
        {
            transform.position = pTransform.position + camPos;
            transform.LookAt(pTransform.position);
        }

        if (furthestCam > Mathf.RoundToInt(Vector3.Distance(transform.position, pTransform.position)))
        {
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                transform.Translate(Vector3.back);
                camPos = transform.position - pTransform.position;
            }
        }
        if (closestCam < Mathf.RoundToInt(Vector3.Distance(transform.position, pTransform.position))) {
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                transform.Translate(Vector3.forward);
                camPos = transform.position - pTransform.position;
            }
        }
        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            //camPos = Quaternion.AngleAxis(panVel, Vector3.up) * targetPos;
            //transform.position = pTransform.position + camPos;
            //transform.LookAt(pTransform.position);
            print(Vector3.back);
        }
     
      
    }

    void camRotatorMouse()
    {
        //camPos = Quaternion.AngleAxis(-Input.GetAxis("Mouse X") * panVel, Vector3.up) * camPos;
        transform.position = pTransform.position + camPos;
        transform.LookAt(pTransform.position);
    }

    void camRotatorKeyboard()
    {
        camPos = Quaternion.AngleAxis(Input.GetAxis("HorizontalCam") * panVel, Vector3.up) * camPos;
        transform.position = pTransform.position + camPos;
        transform.LookAt(pTransform.position);
    }
}
