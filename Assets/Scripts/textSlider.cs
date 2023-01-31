using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class textSlider : MonoBehaviour
{
    public TextMeshProUGUI numberText;

    private Slider slider;
    [SerializeField] Slider volumeSlider;
    void Start()
    {
        slider = GetComponent<Slider>();
        SetNumberText(slider.value);
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void SetNumberText(float value)
    {
        numberText.text = value.ToString();
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }
    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}
