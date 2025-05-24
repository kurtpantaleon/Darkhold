using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Handles scene navigation by loading scenes by name.
/// Attach this script to any GameObject to allow scene changes.
/// </summary>
public class NavigateScene : MonoBehaviour
{
    /// <summary>
    /// Loads a scene by its name.
    /// Scene must be added to Build Settings.
    /// </summary>
    /// <param name="sceneName">Name of the scene to load.</param>
    public void LoadScene(string sceneName)
    {
        if (string.IsNullOrEmpty(sceneName))
        {
            Debug.LogError("Scene name is null or empty.");
            return;
        }

        if (!Application.CanStreamedLevelBeLoaded(sceneName))
        {
            Debug.LogError($"Scene '{sceneName}' cannot be loaded. Check Build Settings.");
            return;
        }

        SceneManager.LoadScene(sceneName);
    }

    /// <summary>
    /// Quits the application.
    /// </summary>
    public void QuitGame()
    {
        Debug.Log("Quitting application...");
        Application.Quit();
    }
} 
