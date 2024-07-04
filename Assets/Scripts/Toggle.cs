using UnityEngine;
using UnityEngine.Audio;

public class Toggle : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixerGroup;
    [SerializeField] private string _exposedParameter;

    private float _volumeMax = 0f;
    private float _volumeMin = -80f;

    public void ToggleMute(bool enabled)
    {
        if (enabled)
        {
            _audioMixerGroup.audioMixer.SetFloat(_exposedParameter, _volumeMin);
        }
        else
        {
            _audioMixerGroup.audioMixer.SetFloat(_exposedParameter, _volumeMax);
        }
    }
}
