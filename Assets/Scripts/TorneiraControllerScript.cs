using UnityEngine;
using System.Collections;

public class TorneiraControllerScript : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		//anim.Stop();
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetKeyUp (KeyCode.Space)) 
		if (Input.GetMouseButtonUp(0))
		{
			anim.Stop();
		}
	}
}
