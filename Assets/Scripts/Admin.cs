using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Admin : MonoBehaviour
{
    public Text timeLimitText;
    private float timeLimit;
    public GameObject finishText;

    private PlayerController playerControllerCS;

    void Start()
    {
        timeLimit = 60;
        timeLimitText.text = timeLimit.ToString("f0") + "•b";
        finishText.SetActive(false);

        playerControllerCS = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        if(timeLimit > 0)
        {
            timeLimit -= Time.deltaTime;
        }

        if(timeLimit <= 0)
        {
            timeLimit = 0;
            finishText.SetActive(true);

            playerControllerCS.isFinished = true;
            StartCoroutine("FinishedGame");
        }

        timeLimitText.text = timeLimit.ToString("f0") + "•b";
    }

    IEnumerator FinishedGame()
	{
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("clear");
	}
}
