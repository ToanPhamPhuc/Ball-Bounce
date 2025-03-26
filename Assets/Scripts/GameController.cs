using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool IsGameOver = false;

    private void Update()
    {
        if(IsGameOver)
        {
            RestartGame();
        }
    }
    void RestartGame()
    {
        if(IsGameOver)
        {
            SceneManager.LoadScene("GamePlay");
        }
    }

}
