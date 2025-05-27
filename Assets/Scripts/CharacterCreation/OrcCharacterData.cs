using UnityEngine;

[CreateAssetMenu(fileName = "NewOrcCharacterData", menuName = "Character/Orc Character Data")]
public class OrcCharacterData : CharacterData
{
    // Character Identity
    public override string characterName { get; set; } = "Grommash Bloodaxe";
    public override string awaken { get; set; } = ""; // Empty
    public override string characterClass { get; set; } = "Berserker";
    public override string body { get; set; } = "Mascular";
    public override string eyes { get; set; } = "Red";
    public override string hair { get; set; } = "Bald";
    public override string race { get; set; } = "Orc";
    public override string expertise { get; set; } = ""; // Empty

    public override Sprite characterSprite { get; set; }

    // Saving Throws
    public override float strength { get; set; }
    public override float dexterity { get; set; }
    public override float constitution { get; set; }
    public override float wisdom { get; set; }
    public override float intelligence { get; set; }
    public override float charisma { get; set; }

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
    public override float hitpoints { get; set; } = 10f; // 10 + cons (add logic if needed)
    public override float barrier { get; set; } = 10f; // 10 + wardrobe (add logic if needed)
    public override float exp { get; set; } = 0f;
    public override float level { get; set; } = 1f;

    // Skills and Equipment
    public override string lifeSkills { get; set; } = "Battle Mage";
    public override string basicSkills { get; set; } = "Rage Strike, Battle Cry";
    public override string specialSpells { get; set; } = "Blood Frenzy";
    public override string weapon { get; set; } = "War Axe";
    public override string wardrobe { get; set; } = "Battle Armor";
    public override string items { get; set; } = ""; // Empty

    private void OnEnable()
    {
        // Character Identity
        characterName = "Grommash Bloodaxe";
        awaken = ""; // Empty
        characterClass = "Berserker";
        body = "Mascular";
        eyes = "Red";
        hair = "Bald";
        race = "Orc";
        expertise = ""; // Empty

        // Character Attributes
        hitpoints = 10f; // 10 + cons (add logic if needed)
        barrier = 10f; // 10 + wardrobe (add logic if needed)
        exp = 0f;
        level = 1f;

        // Skills and Equipment
        lifeSkills = "Battle Mage";
        basicSkills = "Rage Strike, Battle Cry";
        specialSpells = "Blood Frenzy";
        weapon = "War Axe";
        wardrobe = "Battle Armor";
        items = ""; // Empty
    }
}
