using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public Button startButton;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
