using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void GameStart()
    {   
        Time.timeScale = 1f;
        Debug.Log("Clicking to start");
        SceneManager.LoadScene("GamePlay", LoadSceneMode.Single);
    }
}
