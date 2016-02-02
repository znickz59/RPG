using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	public KeyCode forward, back, left, right, journal;
	bool isActive = false;
	public GameObject character;
	void Start () 
	{

	}
	
	void Update () 
	{
		if(Input.GetKey (forward)) gameObject.transform.Translate (Vector3.back);
		if(Input.GetKey (back)) gameObject.transform.Translate (Vector3.forward);
		if(Input.GetKey (left)) gameObject.transform.Translate (Vector3.right);
		if(Input.GetKey (right)) gameObject.transform.Translate (Vector3.left);
		if(Input.GetKeyUp(journal)){ character.SetActive (isActive); isActive = !isActive;}
	}
}
