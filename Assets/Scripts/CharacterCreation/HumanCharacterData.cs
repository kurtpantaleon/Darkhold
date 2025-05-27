using UnityEngine;

[CreateAssetMenu(fileName = "NewHumanCharacterData", menuName = "Character/Human Character Data")]
public class HumanCharacterData : CharacterData
{
    // Character Identity
    public override string characterName { get; set; } = "Adrian Voss";
    public override string awaken { get; set; } = ""; // Empty
    public override string characterClass { get; set; } = "Pyromancer";
    public override string body { get; set; } = "Mascular";
    public override string eyes { get; set; } = "Brown";
    public override string hair { get; set; } = "Short";
    public override string race { get; set; } = "Human";
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
    public override string lifeSkills { get; set; } = "Scholar";
    public override string basicSkills { get; set; } = "Firelash, Blazing Ward";
    public override string specialSpells { get; set; } = "Inferno Surge";
    public override string weapon { get; set; } = "Fire Gauntlet";
    public override string wardrobe { get; set; } = "Embercloak";
    public override string items { get; set; } = ""; // Empty
}
