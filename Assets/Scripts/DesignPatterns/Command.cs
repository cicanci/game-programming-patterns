using UnityEngine;

public interface ICommand
{
    void Execute();
}

public class JumpCommand : ICommand
{
    public void Execute()
    {
        Debug.Log("Execute command: Jump");
    }
}

public class FireCommand : ICommand
{
    public void Execute()
    {
        Debug.Log("Execute command: Fire");
    }
}

public class ReloadCommand : ICommand
{
    public void Execute()
    {
        Debug.Log("Execute command: Reload");
    }
}

public class SwapWeaponCommand : ICommand
{
    public void Execute()
    {
        Debug.Log("Execute command: Swap Weapon");
    }
}
