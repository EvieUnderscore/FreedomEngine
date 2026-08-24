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

        public GameObject2D(Transform2D transform = null)
        {
            if (transform != null)
            {
                this.transform = transform;
            }
        }

        public void Update(GameTime gameTime) {}

        public virtual void Draw(Renderer renderer) {}
    }
}
