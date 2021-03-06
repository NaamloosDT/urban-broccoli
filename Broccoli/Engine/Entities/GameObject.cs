﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broccoli.Engine.Entities
{
	public class GameObject
	{
        public Vector2 Position;
        public Vector2 Velocity;
        public Vector2 Gravity;
        public Texture2D Texture;
        public bool Collision = true;
		public virtual Rectangle HitBox => new Rectangle((int)Position.X, (int)Position.Y, Texture.Width, Texture.Height);

        public virtual void ResetVelocity()
        {
            Velocity = Vector2.Zero;
            Gravity = Vector2.Zero;
        }

        public GameObject(Texture2D texture)
        {
            Texture = texture;
        }

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture,HitBox,Color.White);
        }

        public virtual void Update(GameTime gameTime, List<GameObject> entities)
        {

        }

        #region Collision
        protected bool IsTouchingLeft(GameObject entity, float delta)
        {
            if (this.Collision && entity.Collision)
            {
                return HitBox.Right + Velocity.X * delta > entity.HitBox.Left &&
                    HitBox.Left < entity.HitBox.Left &&
                    HitBox.Bottom > entity.HitBox.Top &&
                    HitBox.Top < entity.HitBox.Bottom;
            }
            else
                return false;
        }

        protected bool IsTouchingRight(GameObject entity, float delta)
        {
            if (this.Collision && entity.Collision)
            {
                return HitBox.Left + Velocity.X * delta < entity.HitBox.Right &&
                    HitBox.Right > entity.HitBox.Right &&
                    HitBox.Bottom > entity.HitBox.Top &&
                    HitBox.Top < entity.HitBox.Bottom;
            }
            else
                return false;
        }

        protected bool IsTouchingTop(GameObject entity, float delta)
        {
            if (this.Collision && entity.Collision)
            {
                return HitBox.Bottom + Velocity.Y * delta > entity.HitBox.Top &&
                    HitBox.Top < entity.HitBox.Top &&
                    HitBox.Right > entity.HitBox.Left &&
                    HitBox.Left < entity.HitBox.Right;
            }
            else
                return false;
        }

        protected bool IsTouchingBottom(GameObject entity, float delta)
        {
            if (this.Collision && entity.Collision)
            {
                return HitBox.Top + Velocity.Y * delta < entity.HitBox.Bottom &&
                    HitBox.Bottom > entity.HitBox.Bottom &&
                    HitBox.Right > entity.HitBox.Left &&
                    HitBox.Left < entity.HitBox.Right;
            }
            else
                return false;
        }
        #endregion
    }
}
