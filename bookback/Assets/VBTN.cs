using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTN : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject detail;
    public VirtualButtonBehaviour Vb;
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPreesed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);
        detail.SetActive(false);
    }

    public void OnButtonPreesed(VirtualButtonBehaviour vb)
    {
        detail.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        detail.SetActive(false);
    }
}
