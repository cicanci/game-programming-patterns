using UnityEngine;
using UnityEngine.SceneManagement;

public class MessageQueueExample : MonoBehaviour
{
    private MessageQueue messageQueue = new MessageQueue();

    private void OnEnable()
    {
        messageQueue.AddListener<UpdateColorMessage>(UpdateColor);
    }

    private void OnDisable()
    {
        messageQueue.RemoveListener<UpdateColorMessage>(UpdateColor);
    }

    private void UpdateColor(UpdateColorMessage message)
    {
        Camera.main.backgroundColor = message.NewColor;
    }

    public void ButtonRed()
    {
        messageQueue.SendMessage(new UpdateColorMessage { NewColor = Color.red });
    }

    public void ButtonBlue()
    {
        messageQueue.SendMessage(new UpdateColorMessage { NewColor = Color.blue });
    }

    public void ButtonGreen()
    {
        messageQueue.SendMessage(new UpdateColorMessage { NewColor = Color.green });
    }

    public void ButtonYellow()
    {
        messageQueue.SendMessage(new UpdateColorMessage { NewColor = Color.yellow });
    }

    public void ButtonBack()
    {
        SceneManager.LoadScene(0);
    }
}
