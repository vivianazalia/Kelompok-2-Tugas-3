using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ShooterSpace.Module.Bullet
{
    public class BulletModel : BaseModel, IBulletModel
    {
        public int Size { get; private set; } = 5;
        public int Damage { get; private set; } = 1;
        public float Speed { get; private set; } = 1f;
        public Vector2 Origin { get; private set; }
        public GameObject Prefab { get; private set; }

        private List<GameObject> BulletList = new List<GameObject>();

        public void SetPrefab()
        {
            Prefab = Resources.Load<GameObject>("Prefabs/Bullet");
        }

        public GameObject GetBullet()
        {
            foreach(var b in BulletList)
            {
                if (!b.activeInHierarchy)
                {
                    b.SetActive(true);
                    return b;
                }
            }

            return null;
        }
    }

}
