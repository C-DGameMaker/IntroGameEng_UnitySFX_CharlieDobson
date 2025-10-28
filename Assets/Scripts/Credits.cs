using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject credits;

    public void onXButton()
    {
        mainMenu.SetActive(true);
        credits.SetActive(false);
    }
}
