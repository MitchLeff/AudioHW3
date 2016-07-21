using UnityEngine;
using System.Collections;

public class PlayOnEnter : MonoBehaviour {

	public AudioSource source;
	public CharacterController character;
	public AudioClip clip1;
	public AudioClip clip2;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			source.clip = clip1;
			//source.loop = false;
			source.Play ();
		}
	}


	//http://docs.unity3d.com/ScriptReference/Collider.OnTriggerExit.html
	void OnTriggerExit(Collider other) {
		source.clip = clip2;
		//source.loop = true;
		source.Play ();
	}

}
