using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CommandExample : MonoBehaviour
{
    private ICommand _buttonA;
    private ICommand _buttonB;
    private ICommand _buttonX;
    private ICommand _buttonY;

    private List<ICommand> _commands = new List<ICommand> { new JumpCommand(), new FireCommand(), new ReloadCommand(), new SwapWeaponCommand() };

    private void Start()
    {
        Refresh();
    }

    private void Refresh()
    {
        _commands.Shuffle();

        _buttonA = _commands[0];
        _buttonB = _commands[1];
        _buttonX = _commands[2];
        _buttonY = _commands[3];
    }

    public void ButtonA()
    {
        _buttonA.Execute();
    }

    public void ButtonB()
    {
        _buttonB.Execute();
    }

    public void ButtonX()
    {
        _buttonX.Execute();
    }

    public void ButtonY()
    {
        _buttonY.Execute();
    }

    public void ButtonRefresh()
    {
        Refresh();
    }

    public void ButtonBack()
    {
        SceneManager.LoadScene(0);
    }
}
