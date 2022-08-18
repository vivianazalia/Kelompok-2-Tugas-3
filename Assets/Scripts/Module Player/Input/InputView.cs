using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;
using ShooterSpace.Module.PubSubMessage;

// script ini dimasukan ke gameobject player
public class InputView : BaseView
{
    public event System.Action OnLeft;
    public event System.Action OnRight;
    public event System.Action OnShoot;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            OnLeft?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            OnRight?.Invoke();
        }
        if(Input.GetMouseButtonDown(0))
        {
            OnShoot?.Invoke();
        }

    }
}
