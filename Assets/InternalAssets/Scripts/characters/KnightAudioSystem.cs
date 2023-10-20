using UnityEngine;

public class KnightAudioSystem : MonoBehaviour
{
    [SerializeField] private AudioClip helloEn, helloRu;

    private AudioSource asKnight;

    void Start()
    {
        asKnight = GetComponent<AudioSource>();
        SetLanguage();
    }

    void SetLanguage()
    {
        if (Application.systemLanguage.ToString() == "Russian")
        {
            asKnight.clip = helloRu;
        }
        else
        {
            asKnight.clip = helloEn;
        }
    }

    void OnMouseDown()
    {
        SayHi();
    }

    void SayHi()
    {
        asKnight.Play();
    }
}
