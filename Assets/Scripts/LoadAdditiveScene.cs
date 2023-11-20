using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAdditiveScene : MonoBehaviour
{
    [SerializeField] string _sceneName;

    void Start()
    {
        // Load the robotic arm scene
        SceneManager.LoadScene(_sceneName, LoadSceneMode.Additive);
    }
}
