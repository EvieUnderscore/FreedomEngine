using FreedomEngine.Core;
using FreedomEngine.Graphics;
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
    public abstract class GameState : IGameState
    {
        public List<IGameObject> objects { get; set; } = new List<IGameObject>();

        public Renderer renderer;
        public Assets assets;

        public GameState(Renderer renderer, Assets assets)
        {
            this.renderer = renderer;
            this.assets = assets;
        }

        public virtual void Initialize() { }
        
        public virtual void Update(float delta)
        {
            foreach (IGameObject obj in objects)
            {
                obj.Update(delta);
            }
        }

        public virtual void Destroy() { }

        public virtual void Draw()
        {
            foreach (IGameObject obj in objects)
            {
                obj.Draw(renderer);
            }
        }

        public void Add(IGameObject obj)
        {
            objects.Add(obj);
        }
        //public abstract void Draw(SpriteBatch spriteBatch);
    }
}
