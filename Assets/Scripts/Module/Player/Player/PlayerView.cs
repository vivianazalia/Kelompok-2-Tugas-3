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
            if(transform.position.x >= -8.3f)
                transform.Translate(Vector2.left * Time.deltaTime * 5);

        }
        public void MoveRight()
        {
            Debug.Log("Input Right");
            if(transform.position.x <= 8.3f)
                transform.Translate(Vector2.right * Time.deltaTime * 5);
        }
        public void OnShoot()
        {
            // shoot
            Debug.Log("Shoot");
        }
    }
}
