using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK2 : MonoBehaviour {

    public float range = 250f;
    public static float mag = 0f;
    public static float currentMag = 30f;
    public float reloadAmount = 30f;
    public float maxMag = 30f;
    public float bulletForce = 150f;
    public float cooldown = 0.2f;
    public static float raycastScore = 0f;
    float cooldownRemaining = 0;
    public GameObject bulletPrefab;
    public Camera Cam;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        cooldownRemaining -= Time.deltaTime;

        if (Input.GetButton("Fire1") && cooldownRemaining <= 0 && currentMag >= 1)
        {
            cooldownRemaining = cooldown;

            GameObject bullet = (GameObject)Instantiate(bulletPrefab, Cam.transform.position + Cam.transform.forward, Cam.transform.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(Cam.transform.forward * bulletForce, ForceMode.Impulse);
            currentMag = currentMag - 1;
        }
        if (Input.GetKey(KeyCode.Z))
        {
            if (cooldownRemaining <= 0 && currentMag >= 1)
            {
                Shoot();
            }
        }

        if (Input.GetKeyDown(KeyCode.R) && currentMag <= 0 && mag >= 1)
        {
            currentMag = maxMag;
            mag = mag - reloadAmount;
        }

    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(Cam.transform.position, Cam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            cooldownRemaining = cooldown;
            currentMag = currentMag - 1;

            Target50m target50m = hit.transform.GetComponent<Target50m>();
            Target100m target100m = hit.transform.GetComponent<Target100m>();
            Target150m target150m = hit.transform.GetComponent<Target150m>();
            Target200m target200m = hit.transform.GetComponent<Target200m>();
            if (target50m != null)
            {
                raycastScore += 50;
            }
            if (target100m != null)
            {
                raycastScore += 100;
            }
            if (target150m != null)
            {
                raycastScore += 200;
            }
            if (target200m != null)
            {
                raycastScore += 400;
            }
        }
    }

}
