using UnityEngine;
using System.Collections;

public class MoveController : MonoBehaviour {

	public Transform target;
	private float 
		speed = 8.0f,
		maxSpeed = 3.0f;

	void Update () {
		if (target != null) {
			Vector3 v = Vector3.Lerp(
				transform.position, 
				target.position, 
				Time.deltaTime * speed) - transform.position;
			if (v.magnitude > maxSpeed) v = v.normalized * maxSpeed;
			transform.position += v;

			// rotation
			transform.rotation = Quaternion.Lerp(
				transform.rotation,
				target.rotation,
				Time.deltaTime * speed);
		}
	}
}
