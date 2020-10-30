﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(LoadFirstScene), 2f);
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
