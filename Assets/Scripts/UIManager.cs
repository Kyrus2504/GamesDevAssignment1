using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    GameObject Managers;
    // Start is called before the first frame update
    void Start()
    {
        Managers = GameObject.FindWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadFirstLevel(){
        DontDestroyOnLoad(Managers);
        SceneManager.LoadScene("Level01Scene");
        
    }

    public void LoadResourceLevel(){
        DontDestroyOnLoad(Managers);
        SceneManager.LoadScene("ResourceScene");
    }
}