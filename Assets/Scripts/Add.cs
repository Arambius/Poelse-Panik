using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Add : MonoBehaviour
{
    public Text textObjekt;
    public myOrder orderScript;

    void Start()
    {
        
    }


    public void OnButtonPress()
    {
        orderScript.sausages++;
        textObjekt.text = "Pølle: " + orderScript.sausages;
    }
}