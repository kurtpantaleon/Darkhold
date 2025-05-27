using UnityEngine;

[CreateAssetMenu(fileName = "NewElfCharacterData", menuName = "Character/Elf Character Data")]
public class CharacterData : ScriptableObject
{
    // Character Identity
    public string characterName = "Thalorin Starbloom";
    public string awaken = ""; // Empty
    public string characterClass = "Hydromancer";
    public string body = "Agile";
    public string eyes = "Green";
    public string hair = "Long";
    public string race = "Elf";
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
    public string lifeSkills = "Spellweaver";
    public string basicSkills = "Tidal Wave, Frozen Touch";
    public string specialSpells = "Aqua Veil";
    public string weapon = "Glacier Chakrams";
    public string wardrobe = "Frostshroud Coat";
    public string items = ""; // Empty
}
