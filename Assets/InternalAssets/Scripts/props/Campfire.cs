using UnityEngine;

public class Campfire : MonoBehaviour
{
    [SerializeField] private GameObject textBubble;

    private Animator aFire;
    private AudioSource asCampfire;
    private ParticleSystem psSmoke;

    private bool isBurning = false;

    void Start()
    {
        aFire = GetComponentInChildren<Animator>();
        asCampfire = GetComponent<AudioSource>();
        psSmoke = GetComponentInChildren<ParticleSystem>();
    }

    void OnMouseDown()
    {
        if (textBubble.activeSelf)
        {
            textBubble.SetActive(false);
        }
        
        if (isBurning)
            {
                isBurning = false;
                aFire.SetBool("isBurning", false);
                asCampfire.Stop();
                psSmoke.Stop();
            }
        else
            {
                isBurning = true;
                aFire.SetBool("isBurning", true);
                asCampfire.Play();
                psSmoke.Play();
            }
    }
}
