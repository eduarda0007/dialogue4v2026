using UnityEngine;

public class PortaController : MonoBehaviour
{
    public Animator anim;
    private bool isOpen;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            InteractOM.OnInteract += OpenClose;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            InteractOM.OnInteract -= OpenClose;
        }
    }

    private void OpenClose()
    {
        if (!isOpen)
        {
            anim.Play("Porta abrindo");
            isOpen = true;
        }
        else
        {
            anim.Play("PortaFechando");
            isOpen = false;
        }
    }
}