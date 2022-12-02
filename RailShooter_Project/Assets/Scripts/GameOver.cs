using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(GoMain());
    }

    IEnumerator GoMain()
    {
        yield return new WaitForSeconds(8f);

        SceneManager.LoadScene("Main");
    }
}
