using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class SimpleDialogV3 : BaseNode {

	[Input] public string entry;
    [TextArea(10, 20)] public string dialogText;
    [Output] public string exit;

    [Header("Visuals")]
    public Sprite actorImage;
    public Sprite backgroundImage;

    [Header("Audio")]
    public BackgroundMusicType backgroundMusic;

    [Header("Animation")]
    public bool slideInActor;

    [Header("Choices")]
    [Output] public string choiceA;
    [Output] public string choiceB;
    [Output] public string choiceC;
    public string choiceAText;
    public string choiceBText;
    public string choiceCText;

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

    public string GetChoiceAText() {
        return choiceAText;
    }

    public string GetChoiceBText() {
        return choiceBText;
    }

    public string GetChoiceCText() {
        return choiceCText;
    }
}