using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameOverMenu;

    private void OnEnable()
    {
        Player.OnPlayerDeath += EnableGameOverMenu;
    }

    private void OnDisable()
    {
        Player.OnPlayerDeath -= EnableGameOverMenu;
    }
   
   public void EnableGameOverMenu()
   {
    gameOverMenu.SetActive(true);
   }

   public void RestartLevel()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }

   public void GoToMainMenu()
   {
    SceneManager.LoadScene("Main Menu");
   }
}
