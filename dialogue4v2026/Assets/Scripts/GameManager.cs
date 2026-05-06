using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public GameState CurrentState { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        SetState(GameState.Iniciando);
    }

    private void Start()
    {
        LoadScene("Splash");
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Menu")
        {
            SetState(GameState.MenuPrincipal);
        }
        else if (scene.name == "SampleScene")
        {
            SetState(GameState.Gameplay);
        }
    }

    private void SetState(GameState newState)
    {
        CurrentState = newState;
        Debug.Log("Estado atual do jogo: " + CurrentState);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }
}