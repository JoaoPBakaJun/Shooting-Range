using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour 
{
	public Text scoreText;


	public Text ammoTextAK;
	public Text magTextAK;

	public float TotalScore = 0f;
	public float ammoTextF = 0f;
	public float magTextF = 0f;
	public float ammoTextFAK = 0f;
	public float magTextFAK = 0f;

	
	// Update is called once per frame
	void Update () {



		TotalScore = Target50m.score + Target100m.score
			+ Target150m.score + Target200m.score;

		/*ammoTextF = Gun.mag;
		magTextF = Gun.currentMag;

		ammoTextFAK = AK.mag;
		magTextFAK = AK.currentMag;*/

		scoreText.text = TotalScore.ToString ();
		/*ammoText.text = ammoTextF.ToString ("0");
		magText.text = magTextF.ToString ("0");
		ammoTextAK.text = ammoTextFAK.ToString ("0");
		magTextAK.text = magTextFAK.ToString ("0");*/

	}
}
