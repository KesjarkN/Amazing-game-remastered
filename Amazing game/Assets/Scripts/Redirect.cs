using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Redirect : MonoBehaviour
{
    public string sceneName;
    public Animator animator;

    public void redirect() {
        Invoke("r", 2f);
        animator.SetTrigger("fadeout");

    }

    private void r() {
        SceneManager.LoadScene(this.sceneName);
    }

    public void quit() {
        Invoke("q", 2f);
        animator.SetTrigger("fadeout");


    }

    private void q() {
        Application.Quit();
    }
  
}
