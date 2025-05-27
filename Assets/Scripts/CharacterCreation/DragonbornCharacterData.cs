using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacterData", menuName = "Character/Character Data")]
public class CharacterData : ScriptableObject
{
    // Character Identity
    public string characterName = "Xyra Stormfang";
    public string awaken = ""; // Empty
    public string characterClass = "Enchanter";
    public string body = "Agile";
    public string eyes = "Red";
    public string hair = "Bald";
    public string race = "Dragonborn";
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
    public string lifeSkills = "Wild Mage";
    public string basicSkills = "Mind Weave, Arcane Infusion";
    public string specialSpells = "Grave Knowledge";
    public string weapon = "Bone Scythe";
    public string wardrobe = "Shadow Veil";
    public string items = ""; // Empty
}
