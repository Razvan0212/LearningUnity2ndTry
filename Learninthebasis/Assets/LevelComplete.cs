using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public GameObject panel;
    public void Update()
    {
        if (Input.GetKey(KeyCode.Return) && this.isActiveAndEnabled)
            LoadNextLevel();
    }
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
