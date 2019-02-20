using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetOptions : MonoBehaviour
{
    private Slider slider;
    private int originalValue;
    private Toggle toggle;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponentInChildren<Slider>();
        toggle = GetComponentInChildren<Toggle>();
    }

    // Update is called once per frame
    public void SaveValue()
    {
        PlayerPrefs.SetFloat("CameraSensitivity", slider.value);
    }

    public void SaveInvertY()
    {
        // -1 = "normal"
        // 1  = "inverted"
        PlayerPrefs.SetInt("InvertY", toggle.isOn ? 1 : -1);
    }
}
