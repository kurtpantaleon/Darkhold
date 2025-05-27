using UnityEngine;

[CreateAssetMenu(fileName = "NewUndeadCharacterData", menuName = "Character/Undead Character Data")]
public class UndeadCharacterData : CharacterData
{
    // Character Identity
    public override string characterName { get; set; } = "Nyx Hollowborn";
    public override string awaken { get; set; } = ""; // Empty
    public override string characterClass { get; set; } = "Necromancer";
    public override string body { get; set; } = "Slender";
    public override string eyes { get; set; } = "Hollow";
    public override string hair { get; set; } = "Bald";
    public override string race { get; set; } = "Undead";
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
    public override string lifeSkills { get; set; } = "Spellweaver";
    public override string basicSkills { get; set; } = "Death Whisper, Soul Shackle";
    public override string specialSpells { get; set; } = "Grave Knowledge";
    public override string weapon { get; set; } = "Bone Scythe";
    public override string wardrobe { get; set; } = "Shadow Veil";
    public override string items { get; set; } = ""; // Empty
}
