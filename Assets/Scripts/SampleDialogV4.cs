using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class SimpleDialogV4 : BaseNode {

	[Input] public string entry;
    [TextArea(10, 20)] public string dialogText;
    [Output] public string exit;

    [Header("Visuals")]
    public Sprite backgroundImage;

    [Header("Audio")]
    public BackgroundMusicType backgroundMusic;

    public enum BackgroundMusicType {
        SUSPENSE,
        ADVENTURE,
        DRAMA,
        HAPPY
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
