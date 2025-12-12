using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    GameObject creditos;
    GameObject menuPrincipal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Script de cargar escena listo para ejecutarse");
        creditos = GameObject.Find("CreditosCanvas");
        creditos.SetActive(false);
        menuPrincipal = GameObject.Find("MenuCanvas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CargarEscenaPrincipal()
    {
        SceneManager.LoadScene("P6_MinijuegoFinal");
    }

    public void CargarCreditos()
    {
        menuPrincipal.SetActive(false);
        creditos.SetActive(true);
    }

    public void CargarMenuPrincipal()
    {
        creditos.SetActive(false);
        menuPrincipal.SetActive(true);
    }
}
