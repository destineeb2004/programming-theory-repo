using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUIHandler : MonoBehaviour
{
    public Buttons sButton;
    public Buttons oButton;
    public Buttons baButton;
    public Buttons aButton;
    public Buttons blButton;
    public Buttons pButton;
    public void MakeAnotherSmoothie()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void DisableButtons()
    {

    }
}
