using UnityEngine.UI;
using UnityEngine;

public class AKCmag2 : MonoBehaviour
{

    public Text magTextAK;

    // Update is called once per frame
    void Update()
    {
        magTextAK.text = AK2.currentMag.ToString("0");

    }
}