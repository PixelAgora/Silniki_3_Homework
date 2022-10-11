using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToMenuFromGameController : MonoBehaviour
{
    [SerializeField] private Button backToMenuButton;

    private void Awake()
    {
        backToMenuButton.onClick.AddListener(OnBackToMenuButtonClicked);
    }

    private void OnBackToMenuButtonClicked()
    {
        SceneManager.LoadScene("MainMenu",LoadSceneMode.Single);
    }
}
