using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CargarNivel(string NombreNivel)
    {
        SceneManager.LoadScene(NombreNivel);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
