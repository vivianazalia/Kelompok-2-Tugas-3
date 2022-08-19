using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;
using ShooterSpace.Module.PubSubMessage;

namespace ShooterSpace.Module.InputPlayer
{
    public class InputController : ObjectController<InputController, InputView>
    {
        public void Init()
        {
            _view.OnLeft += OnLeftInput;
            _view.OnRight += OnRightInput;
            _view.OnShoot += OnShootInput;
            
        }
        private void OnLeftInput()
        {
            Publish<InputLeftMessage>(new InputLeftMessage());
        }
        private void OnRightInput()
        {
            Publish<InputRightMessage>(new InputRightMessage());
        }
        private void OnShootInput()
        {
            Publish<InputShootMessage>(new InputShootMessage());
        }


    }
}

