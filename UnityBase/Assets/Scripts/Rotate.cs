using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	public GameObject obj;
	Vector3 vect = Vector3.zero;
	public float speed = 10f;
	
	// Update is called once per frame
	void Update () {
		vect = new Vector3 (0, speed * Time.deltaTime, 0);
		obj.transform.Rotate (vect);
	}
}
