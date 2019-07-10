using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{
    public Slider volumeSlider;
    public Text valueCaunt;
    public Button skipSettingsButton;
    public GameObject settingsMenu;
    public GameObject mainMenu;

    void Start()
    {
        skipSettingsButton.onClick.AddListener(skipSettings);
    }

    void Update()
    {
        valueCaunt.text = volumeSlider.value.ToString();
        AudioListener.volume = volumeSlider.value;
    }

    void skipSettings()
    {
        settingsMenu.SetActive(false);
        mainMenu.SetActive(true);

      //  volumeSlider.gameObject.SetActive(false);
    }

}
