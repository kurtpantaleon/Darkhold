using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class SimpleDialogV2 : BaseNode {

	[Input] public string entry;
    [TextArea] public string dialogText;
    [Output] public string  exit;
    public Sprite actorImage;
    public BackgroundMusicType backgroundMusic;
    public Sprite backgroundImage;
    public bool slideInActor;
    public enum BackgroundMusicType {
        SUSPENSE,ADVENTURE,DRAMA,HAPPY
    }
 	public override string getDialogText() {
        return dialogText;
    }

    public override Sprite GetSprite() {
        return backgroundImage; 
    }
    
    public BackgroundMusicType GetBackgroundMusic() {
        return backgroundMusic;
    }
}