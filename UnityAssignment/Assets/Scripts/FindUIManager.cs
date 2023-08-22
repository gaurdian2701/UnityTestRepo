using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindUIManager : MonoBehaviour
{
    [SerializeField] private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();

        switch (button.gameObject.name)
        {
            case "Scene_1_Button":
                button.onClick.AddListener(UIManager.Instance.LoadScene1);
                break;

            case "Scene_2_Button":
                button.onClick.AddListener (UIManager.Instance.LoadScene2);
                break;

            case "Scene_3_Button":
                button.onClick.AddListener(UIManager.Instance.LoadScene3);
                break;

            case "BackButton":
                button.onClick.AddListener(UIManager.Instance.LoadMainScene);
                break;

            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
