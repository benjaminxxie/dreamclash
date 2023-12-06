using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyCounter : MonoBehaviour
{
    private string sceneNameToLoad = "Win";
    public Text enemyText;
    int enemiesLeft = 0;
    bool killedAllEnemies = false;
    void Start () {
        enemiesLeft = 10; // or whatever;

    }

    // Update is called once per frame
    void Update () {
        enemiesLeft = GameObject.FindGameObjectsWithTag("Slime").Length + GameObject.FindGameObjectsWithTag("Turtle").Length;
        // if(Input.GetKeyDown(KeyCode.A))
        // {
        //     enemiesLeft --;
        // }
        if(enemiesLeft == 0)
        {
            endGame();
        }
        DisplayEnemies(enemiesLeft);
    }

    void endGame()
    {
        killedAllEnemies = true;
    }

    void DisplayEnemies(int enemyCount)
    {
        if(killedAllEnemies)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
        else
        {
            enemyText.text = string.Format("Enemies left: {0}", enemyCount);
        }
    }

}