using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryPanel : MonoBehaviour
{
    public GameObject inventoryPanel;
    public TMP_Text itemNameText;
    public Button useButton;
    public Button closeButton;

    private string currentWeapon;

    void Start()
    {
        // Hide inventory panel initially
        inventoryPanel.SetActive(false);
        
        // Add listeners to buttons
        useButton.onClick.AddListener(UseWeapon);
        closeButton.onClick.AddListener(CloseInventory);
    }

    public void ShowInventory(string weaponName)
    {
        currentWeapon = weaponName;
        itemNameText.text = weaponName;
        inventoryPanel.SetActive(true);
    }

    private void UseWeapon()
    {
        // Here you can add logic for using the weapon
        Debug.Log($"Using weapon: {currentWeapon}");
        CloseInventory();
    }

    private void CloseInventory()
    {
        inventoryPanel.SetActive(false);
    }
} 