using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkText : MonoBehaviour
{
    Text blinkText;
    // Start is called before the first frame update
    void Start()
    {
        blinkText = GetComponent<Text>();
        StartCoroutine(PlayBlink(true));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        IEnumerator PlayBlink(bool blink)
        {
            while (blink)
            {
                blinkText.color = blinkText.color = new Color(blinkText.color.r,
                                                          blinkText.color.g,
                                                          blinkText.color.b,
                                                          0f);

                yield return new WaitForSeconds(1f);

                blinkText.color = blinkText.color = new Color(blinkText.color.r,
                                                              blinkText.color.g,
                                                              blinkText.color.b,
                                                              1f);

                yield return new WaitForSeconds(1f);
            }
        }
}
