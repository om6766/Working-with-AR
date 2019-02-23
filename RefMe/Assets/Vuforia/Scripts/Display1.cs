using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Display1 : MonoBehaviour, IVirtualButtonEventHandler
{

    VirtualButtonBehaviour[] virtualButtonBehaviours;
    string vbName;
    public TextMesh T;

    // Use this for initialization
    void Start()
    {

        T = GameObject.Find("t1").GetComponent<TextMesh>();

        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < virtualButtonBehaviours.Length; i++)
            virtualButtonBehaviours[i].RegisterEventHandler(this);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vbName = vb.VirtualButtonName;
        if (vbName == "Display1")
        {
         //Debug.log("");
        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        T.text = "This is a complete referance to the c\n" +
            "and in this book you will learn more than any other\n " +
            "book you have read.";
    }
}