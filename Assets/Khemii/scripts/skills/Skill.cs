using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public abstract class Skill : MonoBehaviour
    {
	protected internal enum Stage { Basic = 1, Low, Medium, High, Best }
	internal static Stage stage = default(Stage);
	protected internal abstract decimal Effect<TAbility>(int index, params TAbility[] Abilities) where TAbility : struct;
	protected internal virtual Stage SkillUp()
	{
		return ++stage;
	}
    }

