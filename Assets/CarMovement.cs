using UnityEngine;
using System.Collections;

public class CarMovement : MonoBehaviour {

	public Collider car;
	private int CarDir = 1;
	public int speed;
	public float leftBound;
	public float rightBound ;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		car.transform.Translate(CarDir * Vector3.down * Time.deltaTime * speed);

		if (car.transform.position.x > leftBound || car.transform.position.x < rightBound) {
			CarDir *= -1;
		}
	}
}