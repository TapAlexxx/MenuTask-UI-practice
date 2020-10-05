using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtonsActions : MonoBehaviour
{
    [SerializeField] private GameObject _panelAboutAuthors;
    [SerializeField] private TMP_Text _textAboutAuthors;

    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void AboutAuthorsButton()
    {
        _panelAboutAuthors.SetActive(true);
    }

    public void ChangeTextAboutAuthors(string userText)
    {
        _textAboutAuthors.text = userText;
    }

    public void ClosePannelAboutAuthors()
    {
        _panelAboutAuthors.SetActive(false);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
