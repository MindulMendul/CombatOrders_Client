using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item: MonoBehaviour 
{
    public Image image;
    public int Att;
    public int Def;
    public int MaxHP;
    public float MovSpd;
    public float AttSpd;
    public int Money;

    void Awake()
    {
        image = GetComponent<Image>();
    }
}
