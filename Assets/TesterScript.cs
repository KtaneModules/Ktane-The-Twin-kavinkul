using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesterScript : MonoBehaviour {
	public KMBombModule Module;
	public KMSelectable Button;
	// Use this for initialization
	void Start () {
		Button.OnInteract += delegate ()
		{
			Module.HandlePass();
			return false;
		};
	}
	
}
