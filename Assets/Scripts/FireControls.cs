using UnityEngine;
using System.Collections;

public class FireControls : MonoBehaviour {

	public Transform muzzlePoint;
	public Transform targetPoint;
	
	public void OnGUI() {
		
		Rect fire = new Rect (Screen.width - 70, Screen.height - 220, 50, 50);
		if (GUI.Button (fire, "Fire")) {
			Fire();		
		}
		
	}
	
	public void Fire() {

		Instantiate(targetPoint, muzzlePoint.position, muzzlePoint.rotation);

		RaycastHit hit;
		
		if (Physics.Raycast (muzzlePoint.position, muzzlePoint.forward, out hit)) {
			hit.transform.root.gameObject.SendMessage ("Hit", hit.point, SendMessageOptions.DontRequireReceiver);
		}
	}

}
