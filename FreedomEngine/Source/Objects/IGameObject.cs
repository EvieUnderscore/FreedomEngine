using FreedomEngine.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreedomEngine.Objects
{
    public interface IGameObject
    {
        void Update(float delta);
        void Draw(Renderer renderer);
    }
}
