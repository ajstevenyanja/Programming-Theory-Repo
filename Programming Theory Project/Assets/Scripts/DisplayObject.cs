using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 4 comments specify each OOP principle implementation

// 1. There are three different colored shapes that inherit from a base “DisplayObject” class (inheritance).
public class DisplayObject : MonoBehaviour
{
    // 4. Code is organized in a way that reduces duplicate code through higher level methods(abstraction).
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            // do something
            DisplayText();
        }
    }

    // 2. When you click on each shape, it prints something different to the screen through an overriden DisplayText() function(polymorphism).
    public virtual void DisplayText()
    {
        // do nothing
    }

    // 3. Each shape contains data, such as its name or color, which are stored as properties with getters and setters (encapsulation).
    public class Shape
    {
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        private string m_name = "not_defined";

        public string Color
        {
            get { return m_color; }
            set { m_color = value; }
        }
        private string m_color = "not_defined";
    }
}
