using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public LayerMask movementMask;
    Camera cam;
    PlayerMotor motor;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
             Ray ray = cam.ScreenPointToRay(Input.mousePosition);

             RaycastHit hit;

             if (Physics.Raycast(ray, out hit, 100, movementMask))
             {
                // Debug.Log("We hit " + hit.collider.name + " " + hit.point);

                // Move our player to what we hit
                motor.MoveToPoint(hit.point);

                // Stop focusing any objects
             }
        }

                if (Input.GetMouseButtonDown(1))
        {
             Ray ray = cam.ScreenPointToRay(Input.mousePosition);

             RaycastHit hit;

             if (Physics.Raycast(ray, out hit, 100))
             {
                // check if we hit an iteractable
                // if we did set it as our focus
             }
        }
    }
}
