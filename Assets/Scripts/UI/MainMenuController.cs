using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{

[SerializeField] private Button startGameButton;
[SerializeField] private Button optionsButton;
[SerializeField] private Button creditsButton;
[SerializeField] private Button quitButton;
[SerializeField] private GameObject MainMenu;
[SerializeField] private GameObject OptionsMenu;
[SerializeField] private GameObject CreditsMenu;

    private void Awake()
    {
        startGameButton.onClick.AddListener(OnStartGameButtonClicked);
        optionsButton.onClick.AddListener(OnOptionsButtonClicked);
        creditsButton.onClick.AddListener(OnSCreditsButtonClicked);
        quitButton.onClick.AddListener(OnQuitButtonClicked);
        
    }

    private void OnStartGameButtonClicked()
    {
        SceneManager.LoadScene("Game",LoadSceneMode.Single);
    }

    private void OnOptionsButtonClicked()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(true);
        CreditsMenu.SetActive(false);
    }

    private void OnSCreditsButtonClicked()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(false);
        CreditsMenu.SetActive(true);
    }

    private void OnQuitButtonClicked()
    {
        Application.Quit();
        Debug.Log("Quitter");
    }

}
