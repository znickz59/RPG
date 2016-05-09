using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Quests : MonoBehaviour
{
    public Text title, description;
	void Start ()
    {
	
	}
	
	void Update ()
    {
        title.text = Quest.Current.Title;
        description.text = Quest.Current.Description;
	}
}
