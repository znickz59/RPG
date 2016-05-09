using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	public KeyCode forward, back, left, right, jump, journal;
    float speed = 0.1f;
	bool isActive = false;
	public GameObject character;
	void Start () 
	{

	}
	
	void Update () 
	{
		if(Input.GetKey (forward)) gameObject.transform.Translate (Vector3.back * speed);
		if(Input.GetKey (back)) gameObject.transform.Translate (Vector3.forward * speed);
		if(Input.GetKey (left)) gameObject.transform.Translate (Vector3.right * speed);
		if(Input.GetKey (right)) gameObject.transform.Translate (Vector3.left * speed);
        if (Input.GetKey(jump)) gameObject.transform.Translate(Vector3.up * speed);
        if (Input.GetKeyUp(journal)){ character.SetActive (isActive); isActive = !isActive;}
	}
}
