﻿using Microsoft.Xna.Framework.Input;
using Newtonsoft.Json;

namespace Broccoli.Engine.Entities
{
	public class Keybinds
	{
		[JsonProperty("left")]
		public Keys Left = Keys.Left;

		[JsonProperty("right")]
		public Keys Right = Keys.Right;

		[JsonProperty("up")]
		public Keys Up = Keys.Up;

		[JsonProperty("down")]
		public Keys Down = Keys.Down;

		[JsonProperty("start")]
		public Keys Start = Keys.Escape;

		[JsonProperty("select")]
		public Keys Select = Keys.F1;

		[JsonProperty("jump")]
		public Keys Jump = Keys.Space;

		[JsonProperty("dash")]
		public Keys Dash = Keys.LeftShift;

		[JsonProperty("atk1")]
		public Keys Attack1 = Keys.Z;

		[JsonProperty("atk2")]
		public Keys Attack2 = Keys.X;

		[JsonProperty("block")]
		public Keys Block = Keys.C;
	}
}