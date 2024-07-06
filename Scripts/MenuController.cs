using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void LoadSnow()
    {
        SceneManager.LoadScene("Snowy");

    }

    public void LoadRain()
    {
        SceneManager.LoadScene("Rainy");

    }

    public void LoadFog()
    {
        SceneManager.LoadScene("Foggy");

    }

    public void LoadGlare()
    {
        SceneManager.LoadScene("Sun Glare");

    }

    public void LoadClear()
    {
        SceneManager.LoadScene("Clear Skies");
    }

}
