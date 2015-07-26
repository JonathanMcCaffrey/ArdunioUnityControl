using UnityEngine;
using System.Collections;
using Uniduino;

#if (UNITY_3_0 || UNITY_3_0_0 || UNITY_3_1 || UNITY_3_2 || UNITY_3_3 || UNITY_3_4 || UNITY_3_5)		
public class BlinkButton : Uniduino.Examples.BlinkButton { } // for unity 3.x
#endif

namespace Uniduino.Examples
{
	public class BlinkButton : MonoBehaviour {
		
		public Arduino arduino;
		
		public int blink_pin = 13;
		void Start () {
			arduino = Arduino.global;

			arduino.Setup(ConfigurePins);

			ConfigurePins ();
		}

		void ConfigurePins ()
		{
			arduino.pinMode(blink_pin, PinMode.OUTPUT);
		}
				
		void OnGUI()
		{

		}

		void Update () {

			//arduino.digitalWrite (blink_pin, Arduino.HIGH); 

			Debug.Log (arduino.digitalRead (blink_pin).ToString ());

			if (arduino.digitalRead (blink_pin) == Arduino.HIGH) {
				gameObject.GetComponent<MeshRenderer> ().material.color = Color.red;	
				
			} else {
				gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;	
			}
		}
	}
}