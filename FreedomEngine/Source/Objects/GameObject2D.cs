using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FreedomEngine.Math;

namespace FreedomEngine.Objects
{
    internal class GameObject2D : IGameObject
    {
        public Transform2D transform;

        public GameObject2D(Transform2D transform)
        {
            this.transform = transform;
        }

        public void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
