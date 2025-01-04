using System;
using System.Collections.Generic;

public class MessageQueue
{
    private readonly Dictionary<Type, List<Delegate>> _listeners;

    public MessageQueue()
    {
        _listeners = new Dictionary<Type, List<Delegate>>();
    }

    /// <summary>
    /// Send a message to all listeners of the message type.
    /// </summary>
    /// <param name="message">Message object to be sent.</param>
    /// <returns>Whether it was sent sucessfuly or not for at least one message type.</returns>
    public bool SendMessage(object message)
    {
        if (_listeners.TryGetValue(message.GetType(), out List<Delegate> messages))
        {
            for (int i = 0; i < messages.Count; i++)
            {
                messages[i].DynamicInvoke(message);
            }
            return true;
        }
        return false;
    }

    /// <summary>
    /// Adds one listener for one specific type if it did not exist.
    /// </summary>
    /// <typeparam name="T">The type of the message.</typeparam>
    /// <param name="listener">The object of the message.</param>
    public void AddListener<T>(Action<T> listener)
    {
        if (_listeners.TryGetValue(typeof(T), out List<Delegate> messages))
        {
            messages.Add(listener);
        }
        else
        {
            messages = new List<Delegate> { listener };
            _listeners.Add(typeof(T), messages);
        }
    }

    /// <summary>
    /// Removes one listener for one specific type.
    /// </summary>
    /// <typeparam name="T">The type of the message.</typeparam>
    /// <param name="listener">The object of the message.</param>
    public void RemoveListener<T>(Action<T> listener)
    {
        if (_listeners.TryGetValue(typeof(T), out List<Delegate> messages))
        {
            messages.Remove(listener);

            // It there are no listeners left, removes the type
            if (messages.Count == 0)
            {
                _listeners.Remove(typeof(T));
            }
        }
    }
}