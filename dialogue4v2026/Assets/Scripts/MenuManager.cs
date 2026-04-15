using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void IniciarJogo()
    {
        Debug.Log("Cliquei em Iniciar");
        GameManager.Instance.LoadScene("SampleScene");
    }

    public void Sair()
    {
        Debug.Log("Cliquei em Sair");
        GameManager.Instance.SairDoJogo();
    }
}