using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchController : MonoBehaviour {
    public GameObject ioConnect;
    public string light;
 
    bool on = false;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown() {
        if (on)
        {
            transform.GetChild(3).gameObject.GetComponent<Animation>().Play("switchOff");
            on = false;
        }
        else
        {
            transform.GetChild(3).gameObject.GetComponent<Animation>().Play("switchOn");
            on = true;

        }
        ioConnect.GetComponent<ioContect>().SwithLight(light);

    }
}
