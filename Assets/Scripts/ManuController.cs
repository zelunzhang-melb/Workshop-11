using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManuController : MonoBehaviour
{
    [SerializeField] GameObject rootMenu;
    [SerializeField] GameObject instructions;
    public void OnClickPlay()
    {
        SceneManager.LoadScene("MainScene");

        // more easy way to get BUGs
        //SceneManager.LoadScene(1);
    }

    public void GoToInstructions()
    {
        rootMenu.SetActive(false);
        instructions.SetActive(true);
    }

    public void GoToRootMenu()
    {
        instructions.SetActive(false);
        rootMenu.SetActive(true);
    }
}
