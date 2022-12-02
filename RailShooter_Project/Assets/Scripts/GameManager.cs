using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score;
    public Text scoreText;
    //public int continueCount;
    public GameObject pauseUI;
    public GameObject continueUI;
    //public Text continueText;
    public Image fadeImg;
    public GameObject gameClearUI;
    public PlayerController pc;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();

       if(pc.hp <= 0)
        {
            PlayerDie();
        }

       if (Input.GetKeyDown(KeyCode.Escape))
        {
            PlayerDie();
        }
    }

    void PlayerDie()
    {
        //StartCoroutine(CountDown());
        continueUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void GameClear()
    {
        gameClearUI.SetActive(true);
        StartCoroutine(DelayGameClear(1f));
    }

    public void ContinueYes()
    {
        continueUI.SetActive(false);
        pc.hp = 5;
        Time.timeScale = 1;
    }

    public void ContinueNo()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("GameOver");
    }

    IEnumerator DelayGameClear(float fadeTime)
    {
        yield return new WaitForSeconds(2f);

        float t = 0;

        while (t < fadeTime)
        {
            t += Time.deltaTime;

            float percent = t / fadeTime;

            fadeImg.color = new Color(fadeImg.color.r,
                                      fadeImg.color.g,
                                      fadeImg.color.b,
                                      Mathf.Lerp(1f, 0, percent));


            //yield return null;

        }

        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene("Main");
    }

    /*IEnumerator CountDown()
    {
        continueUI.SetActive(true);

        for (int i = continueCount; i >= 0; i--)
        {
            yield return new WaitForSeconds(1f);
            continueText.text = i.ToString();

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                continueUI.SetActive(false);
            }

            if (i == 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }*/
}
