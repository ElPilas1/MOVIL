using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //el game manager controla las variables del juego y es accesible a todos
    public   KeyCode Esc = KeyCode.Escape;
    //public AudioClip SelectClip;
    public AudioClip selection;
    public int points, deaths;
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
            SceneManager.LoadScene("Inicio");
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

    public void SetDeaths(int value)
    {
        deaths = value;
    }

    public int GetDeaths()
    {
        return deaths;
    }   


    public void LoadScene(string sceneName)
    {

        SceneManager.LoadScene(sceneName);
        AudioManager.instance.ClearAudio();
        points = 0;
        //AdDisplayManager.instance.ShowAD();
    }

    public void ExitGame() => Application.Quit();

}