using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class SimpleDialogV3 : BaseNode {


  

    [Header("Audio")]
    public BackgroundMusicType backgroundMusic;
	[Input] public string entry;
	[Output] public string a;
	[Output] public string b;

	[TextArea(7,20)]
	public string dialogText;
	public Sprite dialogImage;
    public enum BackgroundMusicType {
        SUSPENSE,
        ADVENTURE,
        DRAMA,
        HAPPY
    }

  
		public override string getDialogText()
	{
		return dialogText;
	}
		public override Sprite GetSprite()
	{
		return dialogImage;
	}

   
    public BackgroundMusicType GetBackgroundMusic() {
        return backgroundMusic;
    }


   
} 
