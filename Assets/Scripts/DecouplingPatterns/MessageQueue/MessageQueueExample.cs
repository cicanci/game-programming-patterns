using UnityEngine;
using UnityEngine.SceneManagement;

public class MessageQueueExample : MonoBehaviour
{
    private MessageQueue _messageQueue = new MessageQueue();

    private void OnEnable()
    {
        _messageQueue.AddListener<UpdateColorMessage>(UpdateColor);
    }

    private void OnDisable()
    {
        _messageQueue.RemoveListener<UpdateColorMessage>(UpdateColor);
    }

    private void UpdateColor(UpdateColorMessage message)
    {
        Camera.main.backgroundColor = message.NewColor;
    }

    public void ButtonRed()
    {
        var message = new UpdateColorMessage { NewColor = Color.red };
        _messageQueue.SendMessage(message);
    }

    public void ButtonBlue()
    {
        _messageQueue.SendMessage(new UpdateColorMessage { NewColor = Color.blue });
    }

    public void ButtonGreen()
    {
        _messageQueue.SendMessage(new UpdateColorMessage { NewColor = Color.green });
    }

    public void ButtonYellow()
    {
        _messageQueue.SendMessage(new UpdateColorMessage { NewColor = Color.yellow });
    }

    public void ButtonBack()
    {
        SceneManager.LoadScene(0);
    }
}
