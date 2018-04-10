using UnityEngine;

public class Gun : MonoBehaviour {

    public float range = 100f;
    public float bulletForce = 50f;
    public float cooldown = 0.2f;
    float cooldownRemaining = 0;
    public GameObject bulletPrefab;
    public Camera Cam;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        cooldownRemaining -= Time.deltaTime;

        if (Input.GetButton("Fire1") && cooldownRemaining <= 0)
        {
            cooldownRemaining = cooldown;

            GameObject bullet = (GameObject)Instantiate(bulletPrefab, Cam.transform.position + Cam.transform.forward, Cam.transform.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(Cam.transform.forward * bulletForce, ForceMode.Impulse);
        }
	}

    void Shoot()
    {
        /*RaycastHit hit;
       if ( Physics.Raycast(Cam.transform.position, Cam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }
        }*/
    }
}
