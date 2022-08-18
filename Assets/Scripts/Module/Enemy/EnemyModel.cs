using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ShooterSpace.Module.Enemy
{
    public class EnemyModel : BaseModel, IEnemyModel
    {
        public int Life { get; private set; }
        public Vector2 BoardSize { get; private set; } = new Vector2(5, 4);
        public Vector2 TileSize { get; private set; }
        public Vector2 Offset { get; private set; } = new Vector2(1.5f, 1.5f);
        public Vector2 StartPos { get; private set; }
        public Vector2 EndPos { get; private set; } 
        private GameObject[,] enemies;
        public GameObject Prefab { get; private set; }

        public void SetTileSize()
        {
            Prefab = Resources.Load<GameObject>("Prefabs/Enemy");
            TileSize = Prefab.GetComponent<SpriteRenderer>().size;
            SetStartPos();
        }

        private void SetStartPos()
        {
            Vector2 totalSize = (TileSize + Offset) * (BoardSize - Vector2.one);
            StartPos = new Vector2(0, 0) - (totalSize / 2);
            EndPos = StartPos + totalSize;
        }

        public void SetEnemyPosition(int x, int y, GameObject obj)
        {
            enemies[x, y] = obj;
        }

        public void SetLife(int life)
        {
            Life = life;
            SetDataAsDirty();
        }

        public void DecreaseLife()
        {
            Life--;
            SetDataAsDirty();
        }
    }

}
