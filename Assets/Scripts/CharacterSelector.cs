using UnityEngine;
using UnityEngine.UI;

public class CharacterSelector : MonoBehaviour
{
    public Image characterDisplay;
    public CharacterStats characterStats; // Reference to a script attached to a display object
    public CharacterData[] characters; // Assign in Inspector

    public void ShowCharacter(int index)
    {
        Debug.Log("Button clicked! Index: " + index);

        if (index >= 0 && index < characters.Length)
        {
            CharacterData data = characters[index];

            // Show sprite
            characterDisplay.gameObject.SetActive(true);
            characterDisplay.sprite = data.characterSprite;
            characterDisplay.color = Color.white;

            // Apply stats to the CharacterStats component
            characterStats.strength = data.strength;
            characterStats.dexterity = data.dexterity;
            characterStats.constitution = data.constitution;
            characterStats.wisdom = data.wisdom;
            characterStats.intelligence = data.intelligence;
            characterStats.charisma = data.charisma;

            characterStats.Aetherics = data.Aetherics;
            characterStats.BeastEmpathy = data.BeastEmpathy;
            characterStats.Arcana = data.Arcana;
            characterStats.MysticEndurance = data.MysticEndurance;
            characterStats.MysticArchives = data.MysticArchives;
            characterStats.Empathy = data.Empathy;
            characterStats.OccultInvestigation = data.OccultInvestigation;
            characterStats.ElementalLore = data.ElementalLore;
            characterStats.SixthSense = data.SixthSense;
            characterStats.DivineKnowledge = data.DivineKnowledge;
            characterStats.ShadowWeaving = data.ShadowWeaving;
            characterStats.WildernessAttunement = data.WildernessAttunement;
            characterStats.ArcanePersuasion = data.ArcanePersuasion;
        }
    }
}
