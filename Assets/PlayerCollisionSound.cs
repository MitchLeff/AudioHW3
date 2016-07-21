using UnityEngine;
using System.Collections;

public class PlayerCollisionSound : MonoBehaviour {

	public AudioSource source;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter (Collision col)
	{
		Debug.Log ("Collided " + col.gameObject.tag);
		if (col.gameObject.tag != "Ground") {

			source.Play ();

		}
	}
}
