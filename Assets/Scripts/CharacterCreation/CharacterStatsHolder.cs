using UnityEngine;

public class CharacterStatsHolder : MonoBehaviour
{
    public static CharacterStatsHolder Instance;
    public CharacterStats stats;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}