
using UnityEngine;
using UnityEngine.UIElements;

public class AudioManager : MonoBehaviour
{
    [Header("---------- Audio Source ----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("---------- Audio Clip ----------")]
    public AudioClip Cutscene;
    public AudioClip Background;

    private void Start()
    {
        musicSource.clip = Cutscene;
        musicSource.Play();

    }
}
