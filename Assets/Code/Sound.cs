using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    //[SerializeField, Tooltip("le nom du sfx en question")]private string name;
    public string objectName;

    //[SerializeField, Tooltip("le sfx a jouer")] private AudioClip clip;
    public AudioClip clip;
    
    //[SerializeField, Tooltip("le nom du sfx en question"), Range(0f,1f )] private float volume;
    public float volume;

    //public static AudioMixerGroup audioMixer;

    [HideInInspector]
    public AudioSource source;
}