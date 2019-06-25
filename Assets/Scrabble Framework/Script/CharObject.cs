using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharObject : MonoBehaviour {

    public char character;
    public Text text;
    public RectTransform rectTransform;
    public int index;

    [Header("Appearance")]
    public Color normalColor;
    public Color selectedColor;

    public CharObject Init(char c)
    {
        character = c;
        text.text = c.ToString();
        gameObject.SetActive(true);
        return this;
    }

}
