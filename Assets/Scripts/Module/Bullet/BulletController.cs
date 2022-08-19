using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using ShooterSpace.Module.BulletObject;
using ShooterSpace.Module.PubSubMessage;

namespace ShooterSpace.Module.Bullet
{
    public class BulletController : BaseController<BulletController>
    {
        public List<GameObject> bullets = new List<GameObject>();

        public GameObject CreateInstanceObject()
        {
            BulletObjectModel bulletModel = new BulletObjectModel();
            GameObject prefab = Resources.Load<GameObject>("Prefabs/Bullet");
            GameObject bulletObj = Object.Instantiate(prefab);
            BulletObjectView bulletView = bulletObj.GetComponent<BulletObjectView>();
            BulletObjectController bulletController = new BulletObjectController();
            InjectDependencies(bulletController);
            bulletController.Init(bulletModel, bulletView);
            return bulletObj;
        }

        public void SpawnBullet(BulletSpawnMessage msg)
        {
            GameObject bullet = GetBullet();
            if(bullet == null)
            {
                bullet = CreateInstanceObject();
                bullets.Add(bullet);
            }
            bullet.transform.position = msg.position;
        }

        public GameObject GetBullet()
        {
            foreach (var b in bullets)
            {
                if (!b.activeInHierarchy)
                {
                    b.SetActive(true);
                    return b;
                }
            }

            return null;
        }

        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
        }
    }
}
