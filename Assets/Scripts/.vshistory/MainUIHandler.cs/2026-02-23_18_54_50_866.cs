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
    public GameObject mainCamera;
    private GameObject smoothie;
    public static MainUIHandler Instance;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        smoothie = GameObject.Find("smoothie");
    }

    public void MakeAnotherSmoothie()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        smoothie.SetActive(false);
    }

    public void BlendHelper()
    {
        DisableButtons();
        Vector3 secondView = new Vector3(3.23f, 6.8f, 0);
        Vector3 rotate = new Vector3(60.277f, -90, 0);
        iTween.MoveTo(mainCamera, secondView, 2);
        iTween.RotateTo(mainCamera, rotate, 2);
        DeleteFruit();

    }

    private void DisableButtons()
    {
        sButton.enabled = false;
        oButton.enabled = false;
        baButton.enabled = false;
        aButton.enabled = false;
        blButton.enabled = false;
        pButton.enabled = false;
    }

    private void EnableButtons()
    {
        sButton.enabled = true;
        oButton.enabled = true;
        baButton.enabled = true;
        aButton.enabled = true;
        blButton.enabled = true;
        pButton.enabled = true;
    }

    private void DeleteFruit()
    {
        Object[] allObjects = FindObjectsByType<GameObject>(FindObjectsSortMode.None);
        foreach(GameObject obj in allObjects)
        {
            if (obj.CompareTag("Fruit"))
            {
                Destroy(obj);
            }
            
        }
    }
}
