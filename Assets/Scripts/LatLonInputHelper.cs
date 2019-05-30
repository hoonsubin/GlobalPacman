using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Globalization;

public class LatLonInputHelper : MonoBehaviour
{
    private TMP_InputField InputText;

    private string objectName;

    // Start is called before the first frame update
    void Start()
    {
        InputText = GetComponent<TMP_InputField>();

        objectName = gameObject.name;
        

        if (objectName.Contains("Latitude"))
        {
            InputText.text = ApplicationModel.latitude.ToString();
            Debug.Log("Changing lat value to: " + InputText.text);
        }
        else
        {
            InputText.text = ApplicationModel.longitude.ToString();
            Debug.Log("Changing lon value to: " + InputText.text);
        }
    }

    public void InputChanged()
    {

        if (objectName.Contains("Latitude"))
        {
            ApplicationModel.latitude = float.Parse(InputText.text, CultureInfo.InvariantCulture.NumberFormat);
            
        }
        else
        {
            ApplicationModel.longitude = float.Parse(InputText.text, CultureInfo.InvariantCulture.NumberFormat);
        }

        Debug.Log($"Changing lat value to: {ApplicationModel.latitude}, {ApplicationModel.longitude}");
    }
}
