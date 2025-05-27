using UnityEngine;

public abstract class CharacterData : ScriptableObject
{
    // Character Identity
    [SerializeField] private string characterName;
    [SerializeField] private string awaken;
    [SerializeField] private string characterClass;
    [SerializeField] private string body;
    [SerializeField] private string eyes;
    [SerializeField] private string hair;
    [SerializeField] private string race;
    [SerializeField] private string expertise;

    [SerializeField] private Sprite characterSprite;

    // Saving Throws
    [SerializeField] private float strength;
    [SerializeField] private float dexterity;
    [SerializeField] private float constitution;
    [SerializeField] private float wisdom;
    [SerializeField] private float intelligence;
    [SerializeField] private float charisma;

    // DC Stats
    [SerializeField] private float _Aetherics;
    [SerializeField] private float _BeastEmpathy;
    [SerializeField] private float _Arcana;
    [SerializeField] private float _MysticEndurance;
    [SerializeField] private float _MysticArchives;
    [SerializeField] private float _Empathy;
    [SerializeField] private float _OccultInvestigation;
    [SerializeField] private float _ElementalLore;
    [SerializeField] private float _SixthSense;
    [SerializeField] private float _DivineKnowledge;
    [SerializeField] private float _ShadowWeaving;
    [SerializeField] private float _WildernessAttunement;
    [SerializeField] private float _ArcanePersuasion;

    // Character Attributes
    [SerializeField] private float hitpoints = 10f;
    [SerializeField] private float barrier = 10f;
    [SerializeField] private float exp = 0f;
    [SerializeField] private float level = 1f;

    // Skills and Equipment
    [SerializeField] private string lifeSkills;
    [SerializeField] private string basicSkills;
    [SerializeField] private string specialSpells;
    [SerializeField] private string weapon;
    [SerializeField] private string wardrobe;
    [SerializeField] private string items;

    // Public read-only properties
    public string CharacterName => characterName;
    public string Awaken => awaken;
    public string CharacterClass => characterClass;
    public string Body => body;
    public string Eyes => eyes;
    public string Hair => hair;
    public string Race => race;
    public string Expertise => expertise;
    public Sprite CharacterSprite => characterSprite;

    public float Strength => strength;
    public float Dexterity => dexterity;
    public float Constitution => constitution;
    public float Wisdom => wisdom;
    public float Intelligence => intelligence;
    public float Charisma => charisma;

    public float Hitpoints => hitpoints;
    public float Barrier => barrier;
    public float Exp => exp;
    public float Level => level;

    public string LifeSkills => lifeSkills;
    public string BasicSkills => basicSkills;
    public string SpecialSpells => specialSpells;
    public string Weapon => weapon;
    public string Wardrobe => wardrobe;
    public string Items => items;

    public float Aetherics => _Aetherics;
    public float BeastEmpathy => _BeastEmpathy;
    public float Arcana => _Arcana;
    public float MysticEndurance => _MysticEndurance;
    public float MysticArchives => _MysticArchives;
    public float Empathy => _Empathy;
    public float OccultInvestigation => _OccultInvestigation;
    public float ElementalLore => _ElementalLore;
    public float SixthSense => _SixthSense;
    public float DivineKnowledge => _DivineKnowledge;
    public float ShadowWeaving => _ShadowWeaving;
    public float WildernessAttunement => _WildernessAttunement;
    public float ArcanePersuasion => _ArcanePersuasion;
} 