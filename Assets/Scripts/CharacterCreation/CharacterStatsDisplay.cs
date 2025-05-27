using UnityEngine;
using UnityEngine.UI;

public class CharacterStatsDisplay : MonoBehaviour
{
    public Text nameText;
    public Text classText;
    public Text bodyText;
    public Text eyesText;
    public Text hairText;
    public Text raceText;
    public Text levelText;
    public Text expText;
    public Text barrierText;
    public Text hitpointsText;
    public Text lifeSkillsText;
    public Text basicSkillsText;
    public Text specialSpellsText;
    public Text weaponText;
    public Text wardrobeText;
    public Text itemsText;
    public Image characterImage;

    void Start()
    {
        var data = SelectedCharacter.currentCharacter;
        if (data == null) return;

        nameText.text = data.characterName;
        classText.text = data.characterClass;
        bodyText.text = data.body;
        eyesText.text = data.eyes;
        hairText.text = data.hair;
        raceText.text = data.race;
        levelText.text = "Level: " + data.level;
        expText.text = "EXP: " + data.exp;
        barrierText.text = "Barrier: " + data.barrier;
        hitpointsText.text = "Hitpoints: " + data.hitpoints;
        lifeSkillsText.text = data.lifeSkills;
        basicSkillsText.text = data.basicSkills;
        specialSpellsText.text = data.specialSpells;
        weaponText.text = data.weapon;
        wardrobeText.text = data.wardrobe;
        itemsText.text = data.items;
        characterImage.sprite = data.characterSprite;
    }
}