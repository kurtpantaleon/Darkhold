using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Button))]
public class ClickSoundEffect : MonoBehaviour
{
    [SerializeField] private AudioClip clickSound;
    private AudioSource audioSource;
    private Button button;

    private void Awake()
    {
        // Get or add AudioSource component
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Get the Button component
        button = GetComponent<Button>();

        // Add click listener
        button.onClick.AddListener(PlayClickSound);
    }

    private void PlayClickSound()
    {
        if (clickSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(clickSound);
        }
    }

    private void OnDestroy()
    {
        // Clean up the event listener
        if (button != null)
        {
            button.onClick.RemoveListener(PlayClickSound);
        }
    }
} 