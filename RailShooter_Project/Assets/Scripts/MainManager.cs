using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public GameObject pressText;
    public GameObject mainUI;
    public GameObject optionUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            pressText.SetActive(false);
            mainUI.SetActive(true);
        }
    }

    public void PressStartBtn()
    {
        SceneManager.LoadScene("Game");
    }
}
