using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {

	public void Awake() {
		IndicatorControl.CreateSlice (transform);
	}

	public void Hit( Vector3 point ) {
		ScoreCounter.score += 5;
	}
}
