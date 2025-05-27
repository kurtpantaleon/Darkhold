using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacterData", menuName = "Character/Character Data")]
public class CharacterData : ScriptableObject
{
    // Character Identity
    public string characterName = "Thrain Ironfist";
    public string awaken = ""; // Empty
    public string characterClass = "Illusionist";
    public string body = "Mascular";
    public string eyes = "Brown";
    public string hair = "Long";
    public string race = "Dwarf";
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
    public string lifeSkills = "Battle Mage";
    public string basicSkills = "Mirror Image, Hallucinate";
    public string specialSpells = "Phantom Strike";
    public string weapon = "Whispercloak";
    public string wardrobe = "Nightmare Orb";
    public string items = ""; // Empty
}
