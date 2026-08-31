using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FreedomEngine.Math;
using FreedomEngine.Graphics;

namespace FreedomEngine.Objects
{
    public class GameObject2D : IGameObject
    {
        public Transform2D transform = new Transform2D();
        public Color color = Color.White;

        public GameObject2D(Transform2D transform = null)
        {
            if (transform != null)
            {
                this.transform = transform;
            }
        }

        public void Update(float delta) {}

        public virtual void Draw(Renderer renderer) {}

        public void SetPosition(float x, float y)
        {
            transform.position.X = x;
            transform.position.Y = y;
        }
        public void SetScale(float s_x, float s_y)
        {
            transform.scale.X = s_x;
            transform.scale.Y = s_y;
        }
        public void SetRotation(float rotation)
        {
            transform.rotation = rotation;
        }
    }
}
