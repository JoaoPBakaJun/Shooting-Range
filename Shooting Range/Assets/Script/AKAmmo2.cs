using UnityEngine.UI;
using UnityEngine;

public class AKAmmo2 : MonoBehaviour
{

    public Text ammoTextAK;

    // Update is called once per frame
    void Update()
    {
         ammoTextAK.text = AK2.mag.ToString("0");
    }
}
