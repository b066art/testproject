using UnityEngine;

public class ConfirmButton : MonoBehaviour
{
    [SerializeField] private string nextSceneName;

    public void LoadNextScene()
    {
        SceneChanger.LoadScene(nextSceneName);
    }
}
