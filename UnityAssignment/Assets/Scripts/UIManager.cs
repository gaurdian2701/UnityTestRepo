using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    private static UIManager _instance;

    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<UIManager>();
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        SceneManager sceneManager;
    }

    public void LoadScene1()
    {
        SceneManager.LoadScene("Scene_1");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("Scene_2");
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene("Scene_3");
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
