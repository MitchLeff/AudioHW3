using UnityEngine;
using System.Collections;

public class PlayOnTrigger : MonoBehaviour {

    public AudioSource toPlay;

    //http://docs.unity3d.com/ScriptReference/Collider.OnTriggerEnter.html
	void OnTriggerEnter(Collider other) {

		//ways to check to see if a specific object has entered the trigger:

		//Presence of a Component:
		//checking to see if the object we collided with has a CharacterController

		CharacterController controller = other.gameObject.GetComponent<CharacterController>();
		if (controller != null) //only change color when character controller found
		{
			if(!toPlay.isPlaying) {
                toPlay.Play();
            }
		}
    }
}
