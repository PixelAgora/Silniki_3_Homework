using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackToMenuButtonController : MonoBehaviour

{

[SerializeField] private Button backButton;
[SerializeField] private GameObject MainMenu;
[SerializeField] private GameObject OptionsMenu;
[SerializeField] private GameObject CreditsMenu;

    private void Awake()
    {
        backButton.onClick.AddListener(OnBackButtonClicked);
    }

    private void OnBackButtonClicked()
    {
        MainMenu.SetActive(true);
        OptionsMenu.SetActive(false);
        CreditsMenu.SetActive(false);
    }

}