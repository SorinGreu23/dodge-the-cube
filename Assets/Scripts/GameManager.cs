using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1.5f;
    public GameObject completeLevelUI;

    public void EndGame()
    {
        //This method is called when the game is over
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER!");
        }
        //Restart the Game
        Invoke("Restart", restartDelay);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
}
