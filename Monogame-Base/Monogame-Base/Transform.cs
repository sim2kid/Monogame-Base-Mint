using Microsoft.Xna.Framework;

namespace Monogame_Base
{
    class Transform
    {
        private Vector3 _position;
        private Vector3 _rotation;
        private Vector3 _scale;

        public Vector3 Position {
            get { return _position; }
            set { _position = value; }
        }
        public Vector3 Rotation
        {
            get { return _rotation; }
            set { _rotation = value; }
        }
        public Vector3 Scale
        {
            get { return _scale; }
            set { _scale = value; }
        }

        private void initialize(Vector3 position, Vector3 rotation, Vector3 scale)
        {
            Position = position;
            Rotation = rotation;
            Scale = scale;
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
