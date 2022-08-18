using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;

namespace ShooterSpace.Module.Character
{
    public class PlayerView : BaseView
    {


        public void MoveLeft()
        {
            Debug.Log("Input Left");
            transform.Translate(Vector2.left * Time.deltaTime * 3);
        }
        public void MoveRight()
        {
            Debug.Log("Input Right");
            transform.Translate(Vector2.right * Time.deltaTime * 3);
        }
        public void OnShoot()
        {
            // shoot
        }
    }
}
