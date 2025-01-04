using UnityEngine;

public class JumpCommand : ICommand
{
    public void Execute()
    {
        Debug.Log("Execute command: Jump");
    }
}
