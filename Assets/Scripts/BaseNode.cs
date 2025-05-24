using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class BaseNode : Node {
//idea lang rito is gawen mo lahat method na gagawen mo for all other nodes
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