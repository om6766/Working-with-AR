using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Display4 : MonoBehaviour, IVirtualButtonEventHandler
{

    VirtualButtonBehaviour[] virtualButtonBehaviours;
    string vbName;
    public TextMesh T;

    // Use this for initialization
    void Start()
    {

        T = GameObject.Find("t4").GetComponent<TextMesh>();

        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < virtualButtonBehaviours.Length; i++)
            virtualButtonBehaviours[i].RegisterEventHandler(this);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vbName = vb.VirtualButtonName;
        if (vbName == "Display4")
        {

        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        T.text = "A book you must read for the\n " +
            "Data Structure and Algorithm from\n" +
            "basic to Advance.";
    }
}