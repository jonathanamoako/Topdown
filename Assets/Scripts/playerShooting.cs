using UnityEngine;
using System.Collections;

public class playerShooting : MonoBehaviour {

    public Bullet bullet;
    public Transform muzzle;
    public float bulletSpeed;
    public float fireRate = 0.3F;
    public float nextFire = 0.0F;

	
	void Start () {
	
	}
	
	
	void Update ()
    {
	    if (Input.GetMouseButton(0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Shoot();
            
        }
	}

    private void Shoot()
    {
        Bullet newBullet = Instantiate(
            bullet,
            muzzle.position,
            muzzle.rotation) as Bullet;

        newBullet.SetSpeed (bulletSpeed);
    }

    

    
}
