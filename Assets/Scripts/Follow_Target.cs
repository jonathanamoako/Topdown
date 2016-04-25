using UnityEngine;
using System.Collections;

public class Follow_Target : MonoBehaviour {

    public Transform target;
    public float smoothTime;

    private Vector3 _offset;
    private Vector3 _velocity = Vector3.zero;

	// Use this for initialization
	void Start () {
        _offset = transform.position - target.position;
	
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        Vector3 targetPosition = target.position + _offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _velocity,
            smoothTime);
	}
}
