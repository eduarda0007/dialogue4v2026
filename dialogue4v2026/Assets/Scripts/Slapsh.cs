using UnityEngine;

public class SplashController : MonoBehaviour
{
    public float tempo = 2f;

    void Start()
    {
        Invoke("IrParaMenu", tempo);
    }

    void IrParaMenu()
    {
        GameManager.Instance.LoadScene("MenuPrincipal");
    }
}