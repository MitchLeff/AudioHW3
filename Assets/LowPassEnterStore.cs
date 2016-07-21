using UnityEngine;
using System.Collections;

public class LowPassEnterStore : MonoBehaviour {

	public AudioSource[] storeSources;
	public AudioSource[] restaurantSources;
	public AudioSource[] kitchenSources;
	public AudioSource[] bathroomSources;
	public GameObject storeTrigger;
	public GameObject restTrigger;
	public GameObject kitchenTrigger;
	public GameObject bathroomTrigger;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		//disable low pass filters from this room

		Debug.Log (other.name);

		//based on which other it is...

		if (other.name == "Trigger enter store") {
			for (int i = 0; i < storeSources.Length; i++) {
				storeSources [i].GetComponent<AudioLowPassFilter> ().enabled = false;
			}
		} else if (other.name == "Trigger enter restaurant") {
			for (int i = 0; i < storeSources.Length; i++) {
				restaurantSources [i].GetComponent<AudioLowPassFilter> ().enabled = false;
			}
		} else if (other.name == "Trigger enter kitchen") {
			for (int i = 0; i < storeSources.Length; i++) {
				kitchenSources [i].GetComponent<AudioLowPassFilter> ().enabled = false;
			}
		} else if (other.name == "Trigger enter bathroom") {
			for (int i = 0; i < storeSources.Length; i++) {
				bathroomSources [i].GetComponent<AudioLowPassFilter> ().enabled = false;
			}
		}


	}


	//http://docs.unity3d.com/ScriptReference/Collider.OnTriggerExit.html
	void OnTriggerExit(Collider other) {
		//add back low pass filters to this room

		for (int i = 0; i < storeSources.Length; i++) {
			storeSources [i].GetComponent<AudioLowPassFilter> ().enabled = true;
		}
	}
}
