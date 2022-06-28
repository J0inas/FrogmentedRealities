using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{

    public AudioMixer audioMixer;

    public Dropdown resolution;

    Resolution[] resolutions;

    void Start()
    {
        resolutions = Screen.resolutions;

        resolution.ClearOptions(); //Alle Optionen clearen

        List<string> options = new List<string>(); //neue Liste für Resolution als String

        int currentResolutionIndex = 0;

        for(int i = 0; i < resolutions.Length; i++) //jedes Element aus resolutions als String in options verpacken
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }

        }

        resolution.AddOptions(options); //Liste zum Dropdown hinzufügen
        resolution.value = currentResolutionIndex;
        resolution.RefreshShownValue();
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution res = resolutions[resolutionIndex];
        Screen.SetResolution(res.width, res.height, Screen.fullScreen);
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }

}
