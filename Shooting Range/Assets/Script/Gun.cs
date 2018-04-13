using UnityEngine;

public class Gun : MonoBehaviour {

    public static float mag = 30f;
    public static float currentMag = 10f;
    public float reloadAmount = 30f;
    public float maxMag = 30f;
    public float bulletForce = 250f;
    public float cooldown = 0.2f;
    float cooldownRemaining = 0;
    public GameObject bulletPrefab;
    public Camera Cam;


	// Use this for initialization
	void Start ()
    {
        mag = 30f;
        currentMag = 10f;
	}
	
	// Update is called once per frame
	void Update ()
    {
       cooldownRemaining -= Time.deltaTime;

		if (Input.GetButton("Fire1") && cooldownRemaining <= 0 && currentMag >= 1)
        {
            cooldownRemaining = cooldown;
            
            GameObject bullet = (GameObject)Instantiate(bulletPrefab, Cam.transform.position + Cam.transform.forward, Cam.transform.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(Cam.transform.forward * bulletForce, ForceMode.Impulse);
            currentMag = currentMag - 1;
        }

    
        if(Input.GetKeyDown(KeyCode.R) && currentMag <= 0 && mag >= 1)
        {
            currentMag = maxMag;
            mag = mag - reloadAmount;
        }

	}

   /* void Shoot()
    {
       RaycastHit hit;
       if ( Physics.Raycast(Cam.transform.position, Cam.transform.forward, out hit, range))
        {
			Debug.Log(hit.transform.name);

            Target50m target50m = hit.transform.GetComponent<Target50m>();
            if(target50m != null)
            {
				target50m.GainScore(gS);
            }
        }
    }*/

}
