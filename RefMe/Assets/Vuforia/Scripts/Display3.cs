using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Display3 : MonoBehaviour, IVirtualButtonEventHandler
{

    VirtualButtonBehaviour[] virtualButtonBehaviours;
    string vbName;
    public TextMesh T;

    // Use this for initialization
    void Start()
    {

        T = GameObject.Find("t3").GetComponent<TextMesh>();

        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < virtualButtonBehaviours.Length; i++)
            virtualButtonBehaviours[i].RegisterEventHandler(this);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vbName = vb.VirtualButtonName;
        if (vbName == "Display3")
        {

        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        T.text = "a Java complete referance book which\n" +
            "gives us the complete understanding of the java\n" +
            "from brginning to the advance.";
    }
}