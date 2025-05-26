using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacterData", menuName = "Character/Character Data")]
public class CharacterData : ScriptableObject
{
    public Sprite characterSprite;

    // Saving Throws
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
    public float hitpoints = 10f;
    public float barrier = 10f;
    public float exp;
    public float level = 1f;
}
