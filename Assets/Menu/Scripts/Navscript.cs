using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navscript : MonoBehaviour
{
    public void LoadMyScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
