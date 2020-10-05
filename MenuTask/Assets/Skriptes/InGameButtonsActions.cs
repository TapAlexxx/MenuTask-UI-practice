using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameButtonsActions : MonoBehaviour
{
    public void LoadMenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
