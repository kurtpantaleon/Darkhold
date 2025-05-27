using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour
{
    public Image characterDisplay;
    public CharacterData[] characters; // Assign in Inspector
    public Button viewStatsButton;

    public void ShowCharacter(int index)
    {
        Debug.Log("Button clicked! Index: " + index);

        if (index >= 0 && index < characters.Length)
        {
            CharacterData data = characters[index];
            SelectedCharacter.currentCharacter = data; // Store the selected character

            // Show sprite
            characterDisplay.gameObject.SetActive(true);
            characterDisplay.sprite = data.CharacterSprite;
            characterDisplay.color = Color.white;

            // DO NOT load the scene here!
        }
    }

    // This method will be called by the View Stats button
    public void GoToViewStats()
    {
        if (SelectedCharacter.currentCharacter != null)
        {
            SceneManager.LoadScene("ViewCharacterStats");
        }
        else
        {
            Debug.LogWarning("No character selected! Please select a character first.");
        }
    }

    void Update()
    {
        viewStatsButton.interactable = (SelectedCharacter.currentCharacter != null);
    }
}
