using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMove : MonoBehaviour
{
 [SerializeField] private Camera cam;
  //  private Camera cam;
    // public GameObject Sphere;
  [SerializeField] private Transform target;
    private Vector3 previousPosition;
  void Start() 
  {
    cam = GameObject.Find("cam").GetComponent<Camera>();
    cam = Camera.main;
    cam.enabled=true;
  }
    void Update()
    {
            if(Input.GetMouseButtonDown(0)) {
            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        }
        if(Input.GetMouseButton(0)) {
            Vector3 direction = (previousPosition - cam.ScreenToViewportPoint(Input.mousePosition));
            cam.transform.position=target.position;
            cam.transform.Rotate(new Vector3(1,0,0), direction.y*180);
            cam.transform.Rotate(new Vector3(0,1,0), -direction.x*180, Space.World);
            cam.transform.Translate(new Vector3(0,0,-10));
            previousPosition= cam.ScreenToViewportPoint(Input.mousePosition);

        }
    }
}
