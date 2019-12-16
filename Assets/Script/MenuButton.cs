using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour {

	// Use this for initialization
	public void GotoMenu(){
		SceneManager.LoadScene("stageselectionmenu");
	}
}
