using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainUIHandler : MonoBehaviour
{
    public Button sButton;
    public Button oButton;
    public Button baButton;
    public Button aButton;
    public Button blButton;
    public Button pButton;

    public void MakeAnotherSmoothie()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void DisableButtons()
    {
        sButton.enabled = false;
        oButton.enabled = false;
        baButton.enabled = false;
        aButton.enabled = false;
        blButton.enabled = false;
        pButton.enabled = false;
    }
}
