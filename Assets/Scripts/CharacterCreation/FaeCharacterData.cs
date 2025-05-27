using UnityEngine;

[CreateAssetMenu(fileName = "NewFaeCharacterData", menuName = "Character/Fae Character Data")]
public class CharacterData : ScriptableObject
{
    // Character Identity
    public string characterName = "Sylphia Starpetal";
    public string awaken = ""; // Empty
    public string characterClass = "Clerics";
    public string body = "Slender";
    public string eyes = "Blue";
    public string hair = "Long";
    public string race = "Fae";
    public string expertise = ""; // Empty

    public Sprite characterSprite;

    // Saving Throws
    public float strength; // Not specified, leave default or set as needed
    public float dexterity; // Not specified, leave default or set as needed
    public float constitution; // Not specified, leave default or set as needed
    public float wisdom; // Not specified, leave default or set as needed
    public float intelligence; // Not specified, leave default or set as needed
    public float charisma; // Not specified, leave default or set as needed

    // DC Stats (Commented out, not used for this character)
    // public float Aetherics;
    // public float BeastEmpathy;
    // public float Arcana;
    // public float MysticEndurance;
    // public float MysticArchives;
    // public float Empathy;
    // public float OccultInvestigation;
    // public float ElementalLore;
    // public float SixthSense;
    // public float DivineKnowledge;
    // public float ShadowWeaving;
    // public float WildernessAttunement;
    // public float ArcanePersuasion;

    // Character Attributes
    public float hitpoints = 10f; // 10 + cons (add logic if needed)
    public float barrier = 10f; // 10 + wardrobe (add logic if needed)
    public float exp = 0f;
    public float level = 1f;

    // Skills and Equipment
    public string lifeSkills = "Mystic Sight";
    public string basicSkills = "Divine Shield, Healing Light";
    public string specialSpells = "Sacred Sense";
    public string weapon = "Radiant Mace";
    public string wardrobe = "Celestial Aegis";
    public string items = ""; // Empty
}
