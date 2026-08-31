using FreedomEngine.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreedomEngine.Objects
{
    public class ObjectGroup
    {
        public List<IGameObject> objects { get; set; }

        public ObjectGroup()
        {
            objects = new List<IGameObject>();

        }

        public void Update(float delta)
        {
            foreach (IGameObject obj in objects)
            {
                obj.Update(delta);
            }
        }

        public void Draw(Renderer renderer)
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
    }
}
