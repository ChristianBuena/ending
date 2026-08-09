using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager: MonoBehaviour
{
    [SerializeField] private GameObject gameOverCanvas;

    public void Start()
    {
        gameOverCanvas.SetActive(false);
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
        
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Exit()
    {
        Time.timeScale = 1f;

        //SceneManager.LoadScene("MainMenu");
    }

}