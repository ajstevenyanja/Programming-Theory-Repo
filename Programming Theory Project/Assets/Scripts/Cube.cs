using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : DisplayObject
{
    Shape myData;
    public GameObject text;

    private void Start()
    {
        myData = new Shape();
        myData.Color = "Green";
        myData.Name = "Cube";
        if (text == null)
        {
            text = GameObject.FindGameObjectWithTag("OutputTextTag");
        }
    }

    public override void DisplayText()
    {
        base.DisplayText();
        text.GetComponent<Text>().text = "Type: " + myData.Name + "\nColor: " + myData.Color;
    }

}
