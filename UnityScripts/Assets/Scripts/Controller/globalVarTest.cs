using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalVarTest : MonoBehaviour {

	public static globalVarTest Instance{ set; get; }

	// Access functions in this script with:
	// globalVarTest.Instance.exampleFunction ();

	void Awake () {
		Instance = this;
		exampleFunction ();
	}

	public void exampleFunction(){
		print ("exampleFunction");
	}

}
