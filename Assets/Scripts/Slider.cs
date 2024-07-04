using UnityEngine;
using UnityEngine.Audio;

public class Slider : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixerGroup;
    [SerializeField] private string _exposedParameter;

    private float correctionAugend = 0.0001f;
    private float correctionMultiplier = 20f;

    public void ChangeVolume(float volume)
    {
        _audioMixerGroup.audioMixer.SetFloat(_exposedParameter, Mathf.Log10(volume + correctionAugend) * correctionMultiplier);
    }
}
