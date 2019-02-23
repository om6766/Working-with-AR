using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Display2 : MonoBehaviour, IVirtualButtonEventHandler
{

    VirtualButtonBehaviour[] virtualButtonBehaviours;
    string vbName;
    public TextMesh T;

    // Use this for initialization
    void Start()
    {

        T = GameObject.Find("t2").GetComponent<TextMesh>();

        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < virtualButtonBehaviours.Length; i++)
            virtualButtonBehaviours[i].RegisterEventHandler(this);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vbName = vb.VirtualButtonName;
        if (vbName == "Display2")
        {

        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        T.text = "this is durjoy dutta's book.\n" +
            "it's a love story and can melt a man\n" +
            "with tha heart of stone";
    }
}