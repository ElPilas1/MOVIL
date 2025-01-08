using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //el game manager controla las variables del juego y es accesible a todos
    private KeyCode Esc = KeyCode.Escape;
    //public AudioClip SelectClip;
    public AudioClip selection;
    public int points;
    public enum GameManagerVariables { TIME, POINTS };//para facilitar el codigo


    private void Awake()
    {
        if (!instance)
        {
            instance = this;//se instancia el objecto
            DontDestroyOnLoad(gameObject);// no se destruye entre cargas

        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {

        if (Input.GetKeyDown(Esc))
        {
            SceneManager.LoadScene("Menu");
            AudioManager.instance.ClearAudio();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            AudioManager.instance.ClearAudio();
        }
    }
    public void SetPoints(int value)
    {
        points = value;
    }
    public int GetPoints()
    {
        return points;
    }





    public void LoadScene(string sceneName)
    {

        SceneManager.LoadScene(sceneName);
        AudioManager.instance.ClearAudio();
    }

    public void ExitGame() => Application.Quit();




}