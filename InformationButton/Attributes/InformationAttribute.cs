using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InformationButtonAttribute : PropertyAttribute
{
    public string titleText = "";
    public string informationText = "";
    public string buttonText = "";

    public InformationButtonAttribute(string buttonText, string title, string information)
    {
        titleText = title;
        informationText = information;
        this.buttonText = buttonText;
    }
}
