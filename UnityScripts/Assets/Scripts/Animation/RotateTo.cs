using UnityEngine;
using System.Collections;

public class RotateTo : MonoBehaviour {

    private Transform ThisTransform = null;
    public float RotSpeed = 90f;

	// Use this for initialization
	void Awake () {
	    ThisTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        
        ThisTransform.rotation *= Quaternion.AngleAxis(RotSpeed * Time.deltaTime, Vector3.up);
        //ThisTransform.rotation = Quaternion.Euler(0f, 90f, 0f);
    }
}
