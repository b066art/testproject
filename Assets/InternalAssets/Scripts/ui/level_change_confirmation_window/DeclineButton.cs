using UnityEngine;

public class DeclineButton : MonoBehaviour
{
    private GameObject window;

    void Start()
    {
        window = transform.parent.gameObject;
    }

    public void CloseWindow()
    {
        window.SetActive(false);
    }
}
