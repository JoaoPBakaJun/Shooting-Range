using UnityEngine.UI;
using UnityEngine;

public class CurrentMag2 : MonoBehaviour
{

    public Text magText;

    // Update is called once per frame
    void Update()
    {
        magText.text = Gun2.currentMag.ToString("0");
    }

}
