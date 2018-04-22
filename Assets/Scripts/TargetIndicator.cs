using UnityEngine;
using System.Collections;

public class TargetIndicator : MonoBehaviour {

	public Transform target;

	public float range = 25f;

	public void SetTarget(Transform newTarget) {
		target = newTarget;
	}

	public void LateUpdate(){

		if (target == null) {
			Destroy(gameObject);
			return;
		}

		float distance = Vector3.Distance (transform.position, target.position);
		float yScale = Mathf.Clamp01 ((range - distance) / range);
		transform.localScale = new Vector3 (1, yScale, 1);

		/*Vector3 lookAt = target.position;
		lookAt.y = transform.position.y;
		transform.LookAt (lookAt);*/

		Vector3 lookAt = target.position;
		lookAt.y = transform.position.y;

		Vector3 relativePos = lookAt - transform.position;
		Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * 1.0f);
	}
}
