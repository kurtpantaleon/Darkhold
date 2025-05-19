using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class BaseNode : Node {

	public virtual string getDialogText()
	{
		return "";
	}
		public virtual Sprite GetSprite()
	{
		return null;
	}

	public virtual ABILITY getAbility()
{
	return ABILITY.WISDOM;
}	
public virtual float getDC()
{
	return 10.0f;
}

}