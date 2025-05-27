using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

[CreateNodeMenu("Damage Node")]
public class DamageNode : BaseNode
{
	[Output] public BaseNode exit;
	[Input] public string entry;
    public int damageAmount = 5;
    [TextArea(3, 5)]
    public string damageDialog;
		public Sprite dialogImage;

    public override string getDialogText() {
        return damageDialog;
    }

    public override Sprite GetSprite() {
        return dialogImage;
    }
}
