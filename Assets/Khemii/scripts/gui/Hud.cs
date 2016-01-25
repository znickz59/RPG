using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hud : MonoBehaviour {
    public Image healthBar, magicBar, staminaBar, expBar;
    public Text levelText;
    public ParticleSystem levelUp;
	void Start ()
    {
        
    }
	
	void Update ()
    {
        healthBar.GetComponentInChildren<Text>().text = Mathf.Round(Hero.Health) + " / " + Hero.MaxHealth;
        healthBar.fillAmount = Hero.Health / Hero.MaxHealth;
        magicBar.GetComponentInChildren<Text>().text = Mathf.Round(Hero.Magic) + " / " + Hero.MaxMagic;
        magicBar.fillAmount = Hero.Magic / Hero.MaxMagic;
        staminaBar.GetComponentInChildren<Text>().text = Mathf.Round(Hero.Stamina) + " / " + Hero.MaxStamina;
        staminaBar.fillAmount = Hero.Stamina / Hero.MaxStamina;
        levelText.text = Hero.Level.ToString();
        expBar.fillAmount = Hero.Experience / Hero.RequiredExperience;
        expBar.GetComponentInChildren<Text>().text = Hero.Experience + " / " + Hero.RequiredExperience;
    }
}
