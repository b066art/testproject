using UnityEngine;

public class KnightAudioSystem : MonoBehaviour
{
    private AudioSource asKnight;

    void Start()
    {
        asKnight = GetComponent<AudioSource>();
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
