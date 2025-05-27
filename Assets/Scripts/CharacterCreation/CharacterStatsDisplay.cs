using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CharacterStatsDisplay : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text classText;
    public TMP_Text bodyText;
    public TMP_Text eyesText;
    public TMP_Text hairText;
    public TMP_Text raceText;
    public TMP_Text levelText;
    public TMP_Text expText;
    public TMP_Text barrierText;
    public TMP_Text hitpointsText;
    public TMP_Text lifeSkillsText;
    public TMP_Text basicSkillsText;
    public TMP_Text specialSpellsText;
    public TMP_Text weaponText;
    public TMP_Text wardrobeText;
    public TMP_Text itemsText;
    public Image characterImage;

    void Start()
    {
        var data = SelectedCharacter.currentCharacter;
        if (data == null) return;

        nameText.text = data.CharacterName;
        classText.text = data.CharacterClass;
        bodyText.text = data.Body;
        eyesText.text = data.Eyes;
        hairText.text = data.Hair;
        raceText.text = data.Race;
        levelText.text = "Level: " + data.Level;
        expText.text = "EXP: " + data.Exp;
        barrierText.text = "Barrier: " + data.Barrier;
        hitpointsText.text = "Hitpoints: " + data.Hitpoints;
        lifeSkillsText.text = data.LifeSkills;
        basicSkillsText.text = data.BasicSkills;
        specialSpellsText.text = data.SpecialSpells;
        weaponText.text = data.Weapon;
        wardrobeText.text = data.Wardrobe;
        itemsText.text = data.Items;
        characterImage.sprite = data.CharacterSprite;
    }

    public void GoBackToCharacterSelect()
    {
        SceneManager.LoadScene("ChooseCharacters");
    }
}