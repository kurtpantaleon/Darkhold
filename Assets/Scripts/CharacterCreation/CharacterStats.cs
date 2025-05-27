using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class CharacterStats : MonoBehaviour
{
    // Character Identity
    public string characterName;
    public string awaken;
    public string characterClass;
    public string body;
    public string eyes;
    public string hair;
    public string race;
    public string expertise;

    // Character Saving Throws
    public float strength;
    public float dexterity;
    public float constitution;
    public float wisdom;
    public float intelligence;
    public float charisma;

    // DC Stats
    public float Aetherics;
    public float BeastEmpathy;
    public float Arcana;
    public float MysticEndurance;
    public float MysticArchives;
    public float Empathy;
    public float OccultInvestigation;
    public float ElementalLore;
    public float SixthSense;
    public float DivineKnowledge;
    public float ShadowWeaving;
    public float WildernessAttunement;
    public float ArcanePersuasion;

    // Character Attributes
    public float hitpoints;
    public float barrier;
    public float exp;
    public float level;

    // Skills and Equipment
    public string lifeSkills;
    public string basicSkills;
    public string specialSpells;
    public string weapon;
    public string wardrobe;
    public string items;
}
