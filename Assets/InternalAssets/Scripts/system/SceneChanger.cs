using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public static SceneChanger instance = null;

    void Awake () {
	    if (instance == null)
        {
	        instance = this;
	    }
        else if(instance == this)
        {
	        Destroy(gameObject);
	    }

	    DontDestroyOnLoad(gameObject);
    }

    public static void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
