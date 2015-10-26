using UnityEngine;
using System.Collections;

public class GroundFellow : MonoBehaviour {
	
	public Transform target;
	
	void Update () {
		transform.position = new Vector3 (target.position.x, 
		                                  transform.position.y, 
		                                  transform.position.z);
	}
}
