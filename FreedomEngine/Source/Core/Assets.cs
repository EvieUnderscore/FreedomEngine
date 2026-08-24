using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace FreedomEngine.Core
{
    public class Assets
    {
        private readonly GraphicsDevice _graphicsDevice;
        public Assets(GraphicsDevice graphicsDevice)
        {
            _graphicsDevice = graphicsDevice;
        }

        private readonly Dictionary<string, Texture2D> _textureCache = new Dictionary<string, Texture2D>();

        public Texture2D GetTexture(String path)
        {
            using (var stream = TitleContainer.OpenStream($"Content/Images/{path}.png"))
            {
                Texture2D texture = Texture2D.FromStream(_graphicsDevice, stream);
                _textureCache.Add(path, texture);
                return texture;
            }
        }

        public Texture2D Image(String path)
        {
            if(_textureCache.TryGetValue(path, out Texture2D _texture))
            {
                return _texture;
            }

            return GetTexture(path);
        }
    }
}
