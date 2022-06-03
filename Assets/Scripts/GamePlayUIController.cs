using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayUIController : MonoBehaviour
{
    private string GAME_PLAY_SCENE = "GamePlay";
     private string MAIN_HOME_SCENE = "MainMenu";
   public void RestartGame(){
       SceneManager.LoadScene(GAME_PLAY_SCENE);
   }

   public void GoHome(){
       SceneManager.LoadScene(MAIN_HOME_SCENE);
   }
}
