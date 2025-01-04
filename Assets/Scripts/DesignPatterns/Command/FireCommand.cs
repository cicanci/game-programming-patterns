using UnityEngine;

public class FireCommand : ICommand
{
    public void Execute()
    {
        Debug.Log("Execute command: Fire");
    }
}
