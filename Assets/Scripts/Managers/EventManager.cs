using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : Manager
{
    public static EventManager Instance => GameManager.Instance.EventManager;
    private Dictionary<EventID, Action<object>> _events;

    private void Awake()
    {
        _events = new Dictionary<EventID, Action<object>>();
    }

    /// <summary>Registers an event for invokation</summary>
    /// <param name="eventType">The name of the event as EventID</param>
    /// <param name="Action<object>">Action with passed arguments on invokation</param>
    public void Register(EventID eventType, Action<object> action)
    {
        Action<object> thisAction;
        if (_events.TryGetValue(eventType, out thisAction))
        {
            thisAction += action;
            _events[eventType] = thisAction;
        }
        else
        {
            thisAction += action;
            _events.Add(eventType, thisAction);
        }
    }

    /// <summary>Unregisters an already registered event</summary>
    /// <param name="eventType">The name of the event as EventID</param>
    /// <param name="Action<object>">Action with passed arguments on invokation</param>
    public void Unregister(EventID eventType, Action<object> action)
    {
        Action<object> thisAction;
        if (_events.TryGetValue(eventType, out thisAction))
        {
            thisAction -= action;
            _events[eventType] = thisAction;
        }
    }

    /// <summary>Invokes an event with given arguments</summary>
    /// <param name="eventType">The name of the event as EventID</param>
    /// <param name="object">Arguments that are going to be passed on event invokation</param>
    public void Invoke(EventID eventType, object message)
    {
        Action<object> thisAction;
        if (_events.TryGetValue(eventType, out thisAction))
        {
            thisAction.Invoke(message);
        }
    }

    /// <summary>Invokes an event without arguments</summary>
    /// <param name="eventType">The name of the event as EventID</param>
    public void Invoke(EventID eventType) => Invoke(eventType, null);
}
