﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class AbilityCheckNode : BaseNode {

	[Input] public string entry;
	[Output] public string success;
	[Output] public string failed;


	[TextArea(7,20)]
	public string dialogText;
	public Sprite dialogImage;
	public float difficultyCheckValue;
	public ABILITY abilityCheck;

		public override string getDialogText()
	{
		return dialogText;
	}
		public override Sprite GetSprite()
	{
		return dialogImage;
	}
    public override ABILITY getAbility()
    {
        return abilityCheck;
    }
	public override float getDC()
{
	return difficultyCheckValue;
}
}