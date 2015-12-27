using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Attributes : MonoBehaviour
{
    public Text strength, vitality, intelligence, willpower, dexterity, endurance, levelPoints;
	void Start ()
    {
	
	}

	void Update ()
    {
        ViewAttributes();
	}
    private void ViewAttributes()
    {
        Abilities abils = Hero.Abils;
        strength.text = abils.Strength.ToString();
        vitality.text = abils.Vitality.ToString();
        intelligence.text = abils.Intelligence.ToString();
        willpower.text = abils.Willpower.ToString();
        dexterity.text = abils.Dexterity.ToString();
        endurance.text = abils.Endurance.ToString();
        levelPoints.text = Hero.AbilityPoints.ToString();
    }
}
