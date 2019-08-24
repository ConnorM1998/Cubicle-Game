using UnityEngine;
using UnityEngine.SceneManagement;


    //'Event' Found within Animation that loads next level

public class LevelComplete : MonoBehaviour {

    public void LoadNextLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
