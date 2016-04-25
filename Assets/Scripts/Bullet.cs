using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    private float _speed;

	// Use this for initialization
	void Start ()
    {
        Destroy(gameObject, 2f);
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);

    }

   public void SetSpeed(float value)
    {
        _speed = value;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

    }
}
