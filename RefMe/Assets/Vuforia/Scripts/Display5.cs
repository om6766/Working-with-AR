using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Display5 : MonoBehaviour, IVirtualButtonEventHandler
{

    VirtualButtonBehaviour[] virtualButtonBehaviours;
    string vbName;
    public TextMesh T;

    // Use this for initialization
    void Start()
    {

        T = GameObject.Find("t5").GetComponent<TextMesh>();

        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < virtualButtonBehaviours.Length; i++)
            virtualButtonBehaviours[i].RegisterEventHandler(this);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vbName = vb.VirtualButtonName;
        if (vbName == "Display5")
        {

        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        T.text = "DataBase and algorithm Book with\n" +
            "complete understanding of DBMS.";
    }
}