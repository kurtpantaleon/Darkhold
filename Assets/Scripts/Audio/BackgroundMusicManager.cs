using UnityEngine;

public class BackgroundMusicManager : MonoBehaviour
{
    public static BackgroundMusicManager Instance { get; private set; }

    [SerializeField] private AudioClip[] backgroundMusicTracks;
    [SerializeField] private float fadeSpeed = 1f;
    [SerializeField] private float volume = 0.5f;

    private AudioSource audioSource;
    private int currentTrackIndex = 0;
    private bool isFading = false;
    private float targetVolume;

    private void Awake()
    {
        // Singleton pattern implementation
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            InitializeAudioSource();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void InitializeAudioSource()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        audioSource.loop = true;
        audioSource.volume = volume;
        targetVolume = volume;

        if (backgroundMusicTracks.Length > 0)
        {
            PlayTrack(0);
        }
    }

    private void Update()
    {
        if (isFading)
        {
            audioSource.volume = Mathf.MoveTowards(audioSource.volume, targetVolume, fadeSpeed * Time.deltaTime);
            
            if (Mathf.Approximately(audioSource.volume, targetVolume))
            {
                isFading = false;
            }
        }
    }

    public void PlayTrack(int trackIndex)
    {
        if (trackIndex < 0 || trackIndex >= backgroundMusicTracks.Length) return;

        currentTrackIndex = trackIndex;
        audioSource.clip = backgroundMusicTracks[trackIndex];
        audioSource.Play();
    }

    public void PlayNextTrack()
    {
        int nextIndex = (currentTrackIndex + 1) % backgroundMusicTracks.Length;
        PlayTrack(nextIndex);
    }

    public void PlayPreviousTrack()
    {
        int previousIndex = (currentTrackIndex - 1 + backgroundMusicTracks.Length) % backgroundMusicTracks.Length;
        PlayTrack(previousIndex);
    }

    public void SetVolume(float newVolume)
    {
        targetVolume = Mathf.Clamp01(newVolume);
        isFading = true;
    }

    public void StopMusic()
    {
        targetVolume = 0f;
        isFading = true;
    }

    public void ResumeMusic()
    {
        targetVolume = volume;
        isFading = true;
    }

    public void PauseMusic()
    {
        audioSource.Pause();
    }

    public void UnPauseMusic()
    {
        audioSource.UnPause();
    }
} 