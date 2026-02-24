using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUIHandler : MonoBehaviour
{
    public void MakeAnotherSmoothie()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
