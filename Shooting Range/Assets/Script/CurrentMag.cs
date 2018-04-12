using UnityEngine.UI;
using UnityEngine;

public class CurrentMag : MonoBehaviour {

	public Text magText;
	
	// Update is called once per frame
	void Update () {
		magText.text = Gun.currentMag.ToString ("0");
	}
}
