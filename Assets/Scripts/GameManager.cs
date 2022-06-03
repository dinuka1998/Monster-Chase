using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    private GameObject[] characters;
    private string GAME_PLAY_SCENE = "GamePlay";

    private int _characterIndex;
    public int CharacterIndex
    {
        get { return _characterIndex; }
        set { _characterIndex = value; }
    }

    private void Awake() 
    {
        
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    private void OnEnable() 
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

     private void OnDisable() 
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode ) 
    {

        if(scene.name == GAME_PLAY_SCENE)
            Instantiate(characters[CharacterIndex]);

    }

} // class
