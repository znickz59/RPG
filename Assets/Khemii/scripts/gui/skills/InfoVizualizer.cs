using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using gobj = UnityEngine.GameObject;
using vector = UnityEngine.Vector2;
public class InfoVizualizer : MonoBehaviour
{

    private string info = string.Empty;
    private bool onOver = false;
    private vector position;
	void Start () 
	{
	
	}
	

	void Update () 
	{
        position = new vector(Input.mousePosition.x, Screen.height - Input.mousePosition.y);
    }
    void OnGUI()
    {
        if(onOver)
        GUI.Box(new Rect(position, new vector(500, 50)), info);
    }
	public void OnSkillOver(gobj gobject)
    {
        onOver = true;
        XmlReader xr = new XmlReader();
        var name = gobject.GetComponentInParent<Skill>().name;
        int item = int.Parse(gobject.name) - 1;
        info = xr.Read(xr.LoadFile("SkillsDescription"), name, item);
    }
    public void OnSkillExit()
    {
        onOver = false;
    }
}
