using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class OnValueChangedText : MonoBehaviour
{
    private Text ValueText;

    private void Start()
    {
        ValueText = GetComponent<Text>();

        ValueText.text = "Zoom Level: " + ApplicationModel.zoom.ToString("0.0");
    }

    public void OnSliderValueChanged(float value)
    {
        ApplicationModel.zoom = value;
        ValueText.text = "Zoom Level: " + ApplicationModel.zoom.ToString("0.0");
        
    }
}
