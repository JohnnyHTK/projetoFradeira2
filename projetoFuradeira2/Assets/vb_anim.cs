using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;



public class vb_anim : MonoBehaviour, IVirtualButtonEventHandler{

    public GameObject  btn_on;
    public GameObject  btn_off;
    public Animator cubeAni;
    

    // Start is called before the first frame update
    void Start()
    {
        btn_on = GameObject.Find("btn_on");
        btn_on.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        btn_off = GameObject.Find("btn_off");
        btn_off.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeAni.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){
        switch(vb.VirtualButtonName) {
		case "btn_on":
            cubeAni.Play("Animation_trigger");
            break;
        case "btn_off":
            cubeAni.Play("none");
            break;
        }
        
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb){
        Debug.Log("Button Released");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
