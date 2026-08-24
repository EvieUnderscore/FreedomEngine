using FreedomEngine.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreedomEngine.Core
{
    public abstract class GameState : IGameState
    {
        public GameState()
        {

        }

        public abstract void Initialize();
        public abstract void Update(GameTime gameTime);
        public abstract void Destroy();
        //public abstract void Draw(SpriteBatch spriteBatch);
    }
}
