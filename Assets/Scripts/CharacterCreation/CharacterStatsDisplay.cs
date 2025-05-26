using UnityEngine;
using UnityEngine.UI;

public class CharacterStatsDisplay : MonoBehaviour
{
    public Text nameText;
    public Text strengthText;
    public Text dexterityText;
    // Add other UI Text fields for each stat

    void Start()
    {
        var stats = CharacterStatsHolder.Instance.stats;
        nameText.text = "Character Name"; // Set this if you have a name field
        strengthText.text = "Strength: " + stats.strength;
        dexterityText.text = "Dexterity: " + stats.dexterity;
        // Set other stats...
    }
}