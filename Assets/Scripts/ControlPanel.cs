using UnityEngine;
using UnityEngine.Audio;

public class ControlPanel : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixerMaster;
    [SerializeField] private AudioMixerGroup _audioMixerButtons;
    [SerializeField] private AudioMixerGroup _audioMixerBackground;

    private string _masterVolume = "MasterVolume";
    private string _soundsVolume = "SoundsVolume";
    private string _backgroundVolume = "BackgroundVolume";

    public void ToggleMaster(bool enabled)
    {
        if (enabled)
        {
            _audioMixerMaster.audioMixer.SetFloat(_masterVolume, -80);
        }
        else
        {
            _audioMixerMaster.audioMixer.SetFloat(_masterVolume, 0);
        }
    }

    public void ChangeVolumeMaster(float volume)
    {
        _audioMixerMaster.audioMixer.SetFloat(_masterVolume, Mathf.Lerp(-80, 0, volume));
    }

    public void ChangeVolumeSounds(float volume)
    {
        _audioMixerButtons.audioMixer.SetFloat(_soundsVolume, Mathf.Lerp(-80, 0, volume));
    }

    public void ChangeVolumeBackground(float volume)
    {
        _audioMixerBackground.audioMixer.SetFloat(_backgroundVolume, Mathf.Lerp(-80, 0, volume));
    }
}
