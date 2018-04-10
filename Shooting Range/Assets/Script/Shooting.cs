using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
	public GameObject bullet_prefab;
	public GameObject bullet2_prefab;
	float bulletForce = 100f;
	public float bulletRange = 100.0f;
	public float cooldown = 0.5f;
	float cooldownRemaining = 0;
	bool weaponSwap = false;

	public GameObject debrisPrefab;

	// Use this for initialization
	void Start () 
	{
		
	}


	// to change weapen prefab make 2 gameobject prefab things and if key press 
	
	// Update is called once per frame
	void Update () 
	{
		cooldownRemaining -= Time.deltaTime;

		if (Input.GetButtonDown (e)) 
		{
			weaponSwap = true;
		}

		if (weaponSwap == false) {
			if (Input.GetButtonDown ("Fire1")) {

				Camera camera = Camera.main;
				GameObject bullet = (GameObject)Instantiate (bullet_prefab, camera.transform.position + camera.transform.forward, camera.transform.rotation);
				bullet.GetComponent<Rigidbody> ().AddForce (camera.transform.forward * bulletForce, ForceMode.Impulse);

			}	
		} 
		else if (weaponSwap == false)
		{
			if (Input.GetButtonDown ("Fire1")) {

				Camera camera = Camera.main;
				GameObject bullet = (GameObject)Instantiate (bullet2_prefab, camera.transform.position + camera.transform.forward, camera.transform.rotation);
				bullet.GetComponent<Rigidbody> ().AddForce (camera.transform.forward * bulletForce, ForceMode.Impulse);

			}	
		}





		/*if (Input.GetButtonDown ("Fire1"))
		{

			Camera camera = Camera.main;
			GameObject bullet = (GameObject)Instantiate (bullet_prefab, camera.transform.position + camera.transform.forward, camera.transform.rotation);
			bullet.GetComponent<Rigidbody> ().AddForce (camera.transform.forward * bulletForce, ForceMode.Impulse);

		}*/

		/*if (Input.GetButton("Fire1") && cooldownRemaining <= 0) 
		{
			cooldownRemaining = cooldown;
			Ray ray = new Ray (Camera.main.transform.position, Camera.main.transform.forward);
			RaycastHit hitInfo;

			if (Physics.Raycast (ray, out hitInfo, bulletRange)) 
			{
				Vector3 hitPoint = hitInfo.point;
				GameObject target = hitInfo.collider.gameObject;

				Debug.Log ("Hit Object: " + target.name);
				Debug.Log ("Hit Point: " + hitPoint);



				if (debrisPrefab != null) 
				{
					Instantiate (debrisPrefab, hitPoint, Quaternion.identity);
				}


			}
		}*/

	}
}
