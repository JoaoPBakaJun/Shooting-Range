using UnityEngine.UI;
using UnityEngine;

public class AKAmmo : MonoBehaviour {

    public Text ammoTextAK;

    // Update is called once per frame
    void Update () {


        ammoTextAK.text = AK.mag.ToString("0");
    }
}
