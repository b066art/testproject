using UnityEngine;

public class Campfire : MonoBehaviour
{
    private Animator aFire;
    private ParticleSystem psSmoke;

    private bool isBurning = false;

    void Start()
    {
        aFire = GetComponentInChildren<Animator>();
        psSmoke = GetComponentInChildren<ParticleSystem>();
    }

    void OnMouseDown()
    {
        if (isBurning)
            {
                isBurning = false;
                aFire.SetBool("isBurning", false);
                psSmoke.Stop();
            }
        else
            {
                isBurning = true;
                aFire.SetBool("isBurning", true);
                psSmoke.Play();
            }
    }
}
