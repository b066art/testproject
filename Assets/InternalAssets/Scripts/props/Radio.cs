using UnityEngine;

public class Radio : MonoBehaviour
{
    [SerializeField] private GameObject textBubble;

    private AudioSource asRadio;
    private ParticleSystem psNotes;

    private bool isPlaying = false;

    void Start()
    {
        asRadio = GetComponent<AudioSource>();
        psNotes = GetComponentInChildren<ParticleSystem>();
    }

    void OnMouseDown()
    {
        if (textBubble.activeSelf)
        {
            textBubble.SetActive(false);
        }

        if (isPlaying)
        {
            isPlaying = false;
            asRadio.Stop();
            psNotes.Stop();
        }
        else
        {
            isPlaying = true;
            asRadio.Play();
            psNotes.Play();
        }
    }
}
