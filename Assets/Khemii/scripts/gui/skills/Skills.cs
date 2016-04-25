using System;
using UnityEngine;
using UnityEngine.UI;

delegate void DisableEventArgs();
delegate void EnableEventArgs(int i);
	public class Skills : MonoBehaviour
	{
	public Image[] skills = new Image[4];
	internal static DisableEventArgs dea = () => {};
	internal static EnableEventArgs eea = i => {};
	void Start()
	{
		dea+=DisableAll;
		eea+=Enable;
	}
	void FixedUpdate()
	{

	}
	void OnDisable()
	{
		dea = null;
		eea = null;
	}
	private void DisableAll()
	{
		foreach(var b in skills)
		{
			b.enabled = false;
			foreach(var v in b.GetComponentsInChildren<Image>())
			{
				v.enabled = false;
			}
		}
	}
	private void Enable(int index)
	{
		skills[index].enabled = true;
		foreach(var v in skills[index].GetComponentsInChildren<Image>())
		{
			v.enabled = true;
		}
	}
	}


