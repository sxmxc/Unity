using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	
	public GUIText []menuList;

	// Use this for initialization
	void Start () {
		int iter = 0;
		Vector2 temp = Vector2.zero;

		foreach (GUIText item in menuList)
		{

			temp.y =(float)(item.transform.position.y * iter);
			item.transform.position = temp;
			iter += 1;

		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
