using UnityEngine.UI;
using UnityEngine;

public class Ammo2 : MonoBehaviour
{

    public Text ammoText;


    // Update is called once per frame
    void Update()
    {
        ammoText.text = Gun2.mag.ToString("0");
    }
}
