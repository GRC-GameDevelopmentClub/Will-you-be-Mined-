using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour {

    void Start()
    {
    }

void OnCollisionEnter2D (Collision2D col)
    {

        Scene scene = SceneManager.GetActiveScene();
        string currentSceneName = SceneManager.GetActiveScene().name;

        print("collision");

        if (col.gameObject.name == "Gem")
        {
            if (currentSceneName == "Scene1")
            {
                SceneManager.LoadScene("Scene2");
            }

            if (currentSceneName == "Scene2")
            {
                SceneManager.LoadScene("Scene1");
            }
        }
    }
}
