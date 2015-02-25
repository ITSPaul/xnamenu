using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace MenuAssessment
{
    public class MenuItem
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
        private Vector2 _position;

        public Vector2 Position
        {
            get { return _position; }
            set { _position = value; }
        }
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private bool _selected;

        public bool Selected
        {
            get { return _selected; }
            set { _selected = value; }
        }
        private bool _chosen;

        public bool Chosen
        {
            get { return _chosen; }
            set { _chosen = value; }
        }

        public MenuItem(int id, string label, Vector2 startPosition)
        {
            _id = id;
            _text = label;
            _position = startPosition;
        }



        internal void draw(SpriteBatch sp, SpriteFont font, Texture2D _tex, Texture2D _stex)
        {
            Vector2 textSize = font.MeasureString(_text);
            Vector2 textPos = _position + new Vector2(_tex.Width - textSize.X,
                                                    _tex.Height - textSize.Y) / 2;
            if(_selected)
                sp.Draw(_stex, _position, Color.White);
            else
                sp.Draw(_tex, _position, Color.White);
            sp.DrawString(font, _text, textPos, Color.White);
        }
    }
}
