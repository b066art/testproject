using UnityEngine;

public class Sign : MonoBehaviour
{
    [SerializeField] GameObject confirmationWindow;

    void OnMouseDown()
    {
        if (confirmationWindow != null)
        {
            confirmationWindow.SetActive(true);
        }
    }
}
