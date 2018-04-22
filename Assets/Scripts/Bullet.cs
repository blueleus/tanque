using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speedbullet = 50;
	private Vector3 hitPoint; 

	public void Update () {

		transform.Translate (Vector3.forward * speedbullet * Time.deltaTime);

		if (Mathf.Abs(transform.position.z) >= 70) {
			Destroy(gameObject);
		}
	}

	public void OnTriggerEnter(Collider other) {
		Debug.Log ("You gave something");
		Destroy(gameObject);
	}
}
