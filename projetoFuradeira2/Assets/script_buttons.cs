using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class script_buttons : MonoBehaviour, IVirtualButtonEventHandler{
    
    public GameObject bt_stop_drill;
    public Animator cubeAni;
    public GameObject bt_tripe;
    public GameObject bt_broca;

    public GameObject stop_drill;
    public GameObject broca;
    public GameObject tripe;

    

    // Start is called before the first frame update
    void Start()
    {

		stop_drill.SetActive(false);
        broca.SetActive(false);
        tripe.SetActive(false);        

        bt_stop_drill = GameObject.Find("stop_drill");
        bt_stop_drill.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        bt_tripe = GameObject.Find("tripe");
        bt_tripe.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        bt_broca = GameObject.Find("broca");
        bt_broca.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        
        cubeAni.GetComponent<Animator>();
    }

     public void OnButtonPressed(VirtualButtonBehaviour vb) {
		Debug.Log(vb.VirtualButtonName);
		Debug.Log("Button pressed!");
        
		switch(vb.VirtualButtonName) {
		case "stop_drill":
			stop_drill.SetActive(true);
            broca.SetActive(false);
            tripe.SetActive(false);
            break;
		case "tripe":
			stop_drill.SetActive(false);
            broca.SetActive(true);
            tripe.SetActive(true);
            break;
        case "broca":
			stop_drill.SetActive(false);
            broca.SetActive(true);
            tripe.SetActive(false);
            break;
         //   default:
         //       throw new UnityException("Button not supported: " + vb.VirtualButtonName);
         //           break;
        }
        
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) { 
		Debug.Log("Button released!");
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
