using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Monogame_Base
{
    class Sprite
    {
        private Transform _transform;
        private Color _color;
        private Texture2D _texture;
        private RigidBody _rigidbody;

        public Transform Transform
        {
            get { return _transform; }
            set { _transform = value; }
        }
        public Texture2D Texture
        {
            get { return _texture; }
            set { _texture = value; }
        }
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public RigidBody RigidBody
        {
            get { return _rigidbody; }
            set { _rigidbody = value; }
        }

        #region Constructors
        private void initialize(Texture2D texture, Color color, Transform transform, RigidBody rigidBody)
        {
            Texture = texture;
            Color = color;
            Transform = transform;
            RigidBody = rigidBody;
        }
        public Sprite(Texture2D texture, Color color, Transform transform, RigidBody rigidbody)
        {
            initialize(texture, color, transform, rigidbody);
        }
        public Sprite(Texture2D texture, Color color, Transform transform)
        {
            initialize(texture, color, transform, new RigidBody());
        }
        public Sprite(Texture2D texture, Color color)
        {
            initialize(texture, color, new Transform(), new RigidBody());
        }
        public Sprite(Game game, string textureURI, Color color, Transform transform, RigidBody rigidbody) 
        {
            initialize(loadTexture(game, textureURI), color, transform, rigidbody);
        }
        public Sprite(Game game, string textureURI, Color color, Transform transform)
        {
            initialize(loadTexture(game, textureURI), color, transform, new RigidBody());
        }
        public Sprite(Game game, string textureURI, Color color)
        {
            initialize(loadTexture(game, textureURI), color, new Transform(), new RigidBody());
        }
        #endregion



        static private Texture2D loadTexture(Game game, string textureURI) {
            return game.Content.Load<Texture2D>(textureURI);
        }
    }
}
