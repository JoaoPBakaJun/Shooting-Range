using UnityEngine.UI;
using UnityEngine;

public class Ammo : MonoBehaviour {

	public Text ammoText;

	
	// Update is called once per frame
	void Update () {
		ammoText.text = Gun.mag.ToString("0");
	}
}
