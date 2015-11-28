using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
    public string Name { get; set; }
    public uint Level { get; set; }
    public CharacterAttributes attributes;
    public CharacterPerformance performance;
    public CharacterSkills skills;
	void Start ()
    {
        attributes = new CharacterAttributes(10, 10, 10);
        performance = CharacterPerformance.CalculatePerformance(attributes);

	}
	

	void Update ()
    {
	
	}
}
