using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Base
{
    class Transform
    {
        public Vector3 position;
        public Vector3 rotation;
        public Vector3 scale;

        private void initialize(Vector3 position, Vector3 rotation, Vector3 scale)
        {
            this.position = position;
            this.rotation = rotation;
            this.scale = scale;
        }

        public Transform(Vector3 position, Vector3 rotation, Vector3 scale)
        {
            initialize(position, rotation, scale);
        }
        public Transform(Vector3 postion, Vector3 rotation)
        {
            initialize(position, rotation, Vector3.Zero);
        }
        public Transform(Vector3 postion)
        {
            initialize(position, Vector3.Zero, Vector3.Zero);
        }
        public Transform()
        {
            initialize(Vector3.Zero, Vector3.Zero, Vector3.Zero);
        }
    }
}
