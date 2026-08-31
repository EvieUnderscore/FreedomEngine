using FreedomEngine.Objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreedomEngine.Core
{
    public interface IGameState
    {

        void Initialize();
        void Update(float delta);
        void Draw();
        void Destroy();
        void Add(IGameObject obj);

    }
}
