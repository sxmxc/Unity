using UnityEngine;
using System.Collections;

public class MainMenuManger : MonoBehaviour {
	

	public void _LoadScene(string lvl){

		Application.LoadLevel (lvl);

	}


	public void _ExitGame(){

		Application.Quit ();

	}

	
}
