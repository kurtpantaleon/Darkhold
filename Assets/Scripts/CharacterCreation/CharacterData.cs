using UnityEngine;

public abstract class CharacterData : ScriptableObject
{
    // Character Identity
    public virtual string characterName { get; set; }
    public virtual string awaken { get; set; }
    public virtual string characterClass { get; set; }
    public virtual string body { get; set; }
    public virtual string eyes { get; set; }
    public virtual string hair { get; set; }
    public virtual string race { get; set; }
    public virtual string expertise { get; set; }

    public virtual Sprite characterSprite { get; set; }

    // Saving Throws
    public virtual float strength { get; set; }
    public virtual float dexterity { get; set; }
    public virtual float constitution { get; set; }
    public virtual float wisdom { get; set; }
    public virtual float intelligence { get; set; }
    public virtual float charisma { get; set; }

    // DC Stats
    public virtual float Aetherics { get; set; }
    public virtual float BeastEmpathy { get; set; }
    public virtual float Arcana { get; set; }
    public virtual float MysticEndurance { get; set; }
    public virtual float MysticArchives { get; set; }
    public virtual float Empathy { get; set; }
    public virtual float OccultInvestigation { get; set; }
    public virtual float ElementalLore { get; set; }
    public virtual float SixthSense { get; set; }
    public virtual float DivineKnowledge { get; set; }
    public virtual float ShadowWeaving { get; set; }
    public virtual float WildernessAttunement { get; set; }
    public virtual float ArcanePersuasion { get; set; }

    // Character Attributes
    public virtual float hitpoints { get; set; } = 10f;
    public virtual float barrier { get; set; } = 10f;
    public virtual float exp { get; set; } = 0f;
    public virtual float level { get; set; } = 1f;

    // Skills and Equipment
    public virtual string lifeSkills { get; set; }
    public virtual string basicSkills { get; set; }
    public virtual string specialSpells { get; set; }
    public virtual string weapon { get; set; }
    public virtual string wardrobe { get; set; }
    public virtual string items { get; set; }
} 