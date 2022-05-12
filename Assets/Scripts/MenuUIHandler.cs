using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public bool UNITY_EDITOR = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
EditorApplication.ExitPlaymode();
#else
        ApplicationException.Quit(); // original code to quit Unity player
#endif
        if (UNITY_EDITOR)
        {
            // run this code
        }
        else
        {
            // run this code
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
