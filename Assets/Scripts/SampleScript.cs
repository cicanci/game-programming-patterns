using UnityEngine;
using UnityEngine.SceneManagement;

public class SampleScript : MonoBehaviour
{
    public void ChangeScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
