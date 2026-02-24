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
    private GameObject mainCamera;
    private GameObject secondCamera;
    private GameObject smoothie;
    public static MainUIHandler Instance;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        smoothie = GameObject.Find("smoothie");
        mainCamera = GameObject.Find("Main Camera");
        secondCamera = GameObject.Find("SecondaryCamera");

        mainCamera.SetActive(true);
        secondCamera.SetActive(false);
    }

    public void MakeAnotherSmoothie()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        smoothie.SetActive(false);
    }

    public void BlendHelper()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        DisableButtons();
        secondCamera.SetActive(true);
        mainCamera.SetActive(false);
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

    public void EnableButtons()
    {
        sButton.enabled = true;
        oButton.enabled = true;
        baButton.enabled = true;
        aButton.enabled = true;
        blButton.enabled = true;
        pButton.enabled = true;
    }
}
