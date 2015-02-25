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
    public class Menu
    {
        bool _active;

        public bool Active
        {
            get { return _active; }
            set { _active = value; }
        }
        Texture2D _tex;

        public Texture2D Tex
        {
            get { return _tex; }
            set { _tex = value; }
        }
        Texture2D _stex;

        private MenuItem[] _menuItems;

        private SpriteFont _spFont;

        public Menu(Vector2 StartingPostion, string[] menuItemsText,
            Texture2D[] textures,SpriteFont spFont )
        {
            _spFont = spFont;
            _tex = textures[0];
            _stex = textures[1];

            int itemGap = 20;

            _menuItems = new MenuItem[menuItemsText.Length];
            for (int i = 0; i < _menuItems.Length; i++)
            {
                _menuItems[i] = new MenuItem(i, menuItemsText[i], StartingPostion);
                StartingPostion += new Vector2(0,_tex.Height + itemGap);
            }
        }

            public void draw(SpriteBatch sp)
            {
                sp.Begin();
                foreach(MenuItem m in _menuItems)
                    m.draw(sp, _spFont, _tex, _stex);
                sp.End();
            }
            
        }
}
