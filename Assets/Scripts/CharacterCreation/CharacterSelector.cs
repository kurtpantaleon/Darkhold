using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour
{
    public Image characterDisplay;
    public CharacterData[] characters; // Assign in Inspector
    public Button viewStatsButton;

    private void Awake()
    {
        // Validate required components
        if (characterDisplay == null)
        {
            Debug.LogError("Character Display Image is not assigned in the Inspector!");
        }
        if (viewStatsButton == null)
        {
            Debug.LogError("View Stats Button is not assigned in the Inspector!");
        }
        if (characters == null || characters.Length == 0)
        {
            Debug.LogError("No characters assigned in the Inspector!");
        }
    }

    public void ShowCharacter(int index)
    {
        Debug.Log("Button clicked! Index: " + index);

        if (characters == null || characters.Length == 0)
        {
            Debug.LogError("No characters available!");
            return;
        }

        if (index >= 0 && index < characters.Length)
        {
            CharacterData data = characters[index];
            if (data != null)
            {
                SelectedCharacter.currentCharacter = data; // Store the selected character

                // Show sprite if characterDisplay is assigned
                if (characterDisplay != null)
                {
                    characterDisplay.gameObject.SetActive(true);
                    characterDisplay.sprite = data.CharacterSprite;
                    characterDisplay.color = Color.white;
                }
            }
            else
            {
                Debug.LogError($"Character data at index {index} is null!");
            }
        }
        else
        {
            Debug.LogError($"Invalid character index: {index}. Valid range is 0 to {characters.Length - 1}");
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
        if (viewStatsButton != null)
        {
            viewStatsButton.interactable = (SelectedCharacter.currentCharacter != null);
        }
    }
}
