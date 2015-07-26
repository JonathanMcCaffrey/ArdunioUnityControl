using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class ArdunioControls : MonoBehaviour {
	
	SerialPort serialPort;
	
	// Use this for initialization
	void Start () {
		serialPort = new SerialPort ("/dev/cu.usbmodem1421", 57600);
		serialPort.Open ();
		serialPort.ReadTimeout = 1;
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (serialPort.IsOpen ) {
			try {
				takePortControls (serialPort.ReadByte ());
			} catch (System.Exception e) {
				
			}
		}
		
	}
	
	bool isBeBlue = false;
	void takePortControls(int control) {
		if (control == 6) {
			isBeBlue = true;
		}
		if (control == 7) {
			isBeBlue = false;
		}
		
		if (isBeBlue) {
			gameObject.GetComponent<MeshRenderer> ().material.color = Color.red;	
			
		} else {
			gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;	
		}
		
	}
}
