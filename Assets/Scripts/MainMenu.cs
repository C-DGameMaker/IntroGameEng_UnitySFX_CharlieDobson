using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject credits;

    private void Start()
    {
        mainMenu.SetActive(true);
        credits.SetActive(false);
    }
    public void onPlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void onQuitButton()
    {
        Application.Quit();
    }

    public void onCreditsButton()
    {
        mainMenu.SetActive(false);
        credits.SetActive(true);
    }

}
