using UnityEngine;
using XNode;

[CreateNodeMenu("Dialog/Multiple Choice Sprite")]
public class MultipleChoiceSpriteDialog : BaseNode
{
    	[Input] public string entry;
    public Sprite spriteA;
    public Sprite spriteB;
    public Sprite spriteC;
    public Sprite spriteD;

	[TextArea(7, 20)]
	public string dialogText;
	public Sprite dialogImage;
    [Output] public BaseNode a;
    [Output] public BaseNode b;
    [Output] public BaseNode c;
    [Output] public BaseNode d;

    public override string getDialogText()
    {
        return dialogText;
    }

    public override Sprite GetSprite()
    {
        return dialogImage; // Or a background if needed
    }
}
