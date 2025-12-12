using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CargarEscenaPrincipal()
    {
        SceneManager.LoadScene("P6_MinijuegoFinal");
    }

    public void CargarEscenaMenuPrincipal()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
