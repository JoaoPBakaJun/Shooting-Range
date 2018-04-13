using UnityEngine.UI;
using UnityEngine;

public class AKCMag : MonoBehaviour {

    public Text magTextAK;

    // Update is called once per frame
    void Update () {
        magTextAK.text = AK.currentMag.ToString("0");

    }
}
