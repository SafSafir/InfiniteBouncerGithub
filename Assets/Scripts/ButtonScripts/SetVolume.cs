using UnityEngine;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string MusicPref = "MusicPref";
    private int firstPlayInt;
    public Slider musicSlider;
    private float musicFloat;
    public AudioSource gameMusic;
    public AudioSource gameOverMusic;

    private void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);

        if (firstPlayInt == 0)
        {
            musicFloat = 1f;
            musicSlider.value = musicFloat;
            PlayerPrefs.SetFloat(MusicPref, musicFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);
        }
        else
        {
            musicFloat = PlayerPrefs.GetFloat(MusicPref);
            musicSlider.value = musicFloat;
        }
    }

    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(MusicPref, musicSlider.value);
    }

    private void OnApplicationFocus(bool focus)
    {
        if (!focus)
            SaveSoundSettings();
    }

    public void UpdateSound()
    {
        gameMusic.volume = musicSlider.value;
        gameOverMusic.volume = musicSlider.value;
    }
}