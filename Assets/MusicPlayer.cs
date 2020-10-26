using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(LoadFirstScene), 2f);
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
