using UnityEngine;

public class ReloadCommand : ICommand
{
    public void Execute()
    {
        Debug.Log("Execute command: Reload");
    }
}
