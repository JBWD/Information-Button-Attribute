using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(InformationButtonAttribute))]
[CanEditMultipleObjects]
public class InformationButtonAttributeDrawer : PropertyDrawer
{

    float buttonHeight = EditorGUIUtility.singleLineHeight;
    InformationButtonAttribute attr;


    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        attr = (InformationButtonAttribute)base.attribute;
        Rect buttonRect = new Rect(position.x, position.y , position.width / 2, buttonHeight);
        if(GUI.Button(buttonRect, attr.buttonText) )
        {
            DisplayMessage();

        }
        Rect adjustedRect = new Rect(position.x, position.y + buttonHeight + 2, position.width, buttonHeight);

        EditorGUI.PropertyField(adjustedRect, property);
        
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return EditorGUI.GetPropertyHeight(property, label,true) + buttonHeight +2;
    }


    public void DisplayMessage()
    {
        

        EditorUtility.DisplayDialog(attr.titleText + " - Information", attr.informationText, "Ok");
        

    }
}
