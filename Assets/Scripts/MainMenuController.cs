using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuController : MonoBehaviour
{
    private string GAME_PLAY_SCENE = "GamePlay";

    public void PlayGame() {

        int selectedCharactor = (int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name.Remove(0, 7)) - 1);
        
        GameManager.instance.CharacterIndex = selectedCharactor;

        SceneManager.LoadScene(GAME_PLAY_SCENE);

    }

} // class
