using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class randommaps : MonoBehaviour
{
    public string[] maps;
    private FadeScene fadeScene;
    private bool changingScene = false;
    void Start()
    {
        fadeScene = GetComponent<FadeScene>();
    }
    void Update()
    {
        if (changingScene && fadeScene.fadeOut==false)
        {
            int random = Random.Range(0, 7);
            Debug.Log(random);
            SceneManager.LoadScene(maps[random]);
        }
    }
    public void pickmap()
    {
        fadeScene.fadeOut = true;
        changingScene = true;
    }
    
}
