using UnityEngine;
using UnityEngine.UI;

public class CharacterSelector : MonoBehaviour
{
    public Image characterDisplay; // Assign in Inspector
    public Sprite[] characterSprites; // Assign in Inspector, order matches buttons

    // Call this from your button, passing the index of the character
    public void ShowCharacter(int index)
    {
        Debug.Log("Button clicked! Index: " + index);
        if (index >= 0 && index < characterSprites.Length)
        {
            characterDisplay.gameObject.SetActive(true); // Enable the image
            characterDisplay.sprite = characterSprites[index];
            characterDisplay.color = Color.white; // Make sure it's visible
        }
    }
}