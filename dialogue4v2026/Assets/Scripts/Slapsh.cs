using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(AguardarESeguir());
    }

    private IEnumerator AguardarESeguir()
    {
        yield return new WaitForSeconds(2f);

        if (GameManager.Instance != null)
        {
            GameManager.Instance.LoadScene("Menu");
        }
        else
        {
            Debug.LogError("GameManager não encontrado na Splash!");
        }
    }
}