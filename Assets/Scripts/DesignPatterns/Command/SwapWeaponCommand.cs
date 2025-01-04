using UnityEngine;

public class SwapWeaponCommand : ICommand
{
    public void Execute()
    {
        Debug.Log("Execute command: Swap Weapon");
    }
}
