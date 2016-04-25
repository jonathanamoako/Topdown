using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    private Rigidbody rb;
    private Vector3 movement = new Vector3();

    // Use this for initialization
    void Awake () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        movement = new Vector3(x, 0f, z);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.up, Vector3.zero);
        float distance;

        if(plane.Raycast (ray, out distance))
        {
            Vector3 point = ray.GetPoint(distance);
            Vector3 adjustedheightPoint = new Vector3(point.x, transform.position.y, point.z);
            transform.LookAt(adjustedheightPoint);
        }
    }

    void FixedUpdate()
    {
        Vector3 velocity = movement * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + velocity);
    }
}
