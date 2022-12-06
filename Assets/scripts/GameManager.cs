using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public List<GameObject> targets;
    private float spawnRate = 1.0f;
    private int score;
    public TextMeshProUGUI gameOverText;
    public bool isgameactive;
    public Button restartbutton;
    public GameObject titleScreen;
    // Start is called before the first frame update
    void Start()
    {
     

}

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTarget()
    {
        while (isgameactive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index =Random.Range(0,targets.Count);
            Instantiate(targets[index]);
            

        }
    }

    public void updatescore(int scoretoadd)
    {
        score += scoretoadd;
        scoreText.text = "score :" + score;
    }

    public void GameOver()
    {
        restartbutton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isgameactive = false;

    }

public void RestartGame()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}


    public void GameStart(int difficulty)
    {
        isgameactive = true;
        spawnRate /= difficulty;
        StartCoroutine(SpawnTarget());
        score = 0;
        updatescore(0);
        titleScreen.gameObject.SetActive(false);
    }
}
