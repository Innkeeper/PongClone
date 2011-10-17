namespace Pong
{
    using System.Collections.Generic;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class Menu
    {

        private List<string> MenuItems;
        private int iterator;
        public string InfoText { get; set; }
        public string Title { get; set; }
        public int Iterator
        {
            get
            {
                return iterator;
            }
            set
            {
                iterator = value;
                if (iterator > MenuItems.Count - 1) iterator = MenuItems.Count - 1;
                if (iterator < 0) iterator = 0;
            }
        }

        public Menu()
        {
            Title = "Pong Clone";
            MenuItems = new List<string>();
            MenuItems.Add("Single Player");
            MenuItems.Add("Multi Player");
            MenuItems.Add("Exit Game");
            Iterator = 0;
            InfoText = string.Empty;
        }

        public int GetNumberOfOptions()
        {
            return MenuItems.Count;
        }

        public string GetItem(int index)
        {
            return MenuItems[index];
        }

        public void DrawMenu(SpriteBatch batch, int screenWidth, SpriteFont arial)
        {
            batch.DrawString(arial, Title, new Vector2(screenWidth / 2 - arial.MeasureString(Title).X / 2, 20), Color.White);
            int yPos = 100;
            for (int i = 0; i < GetNumberOfOptions(); i++)
            {
                Color colour = Color.White;
                if (i == Iterator)
                {
                    colour = Color.Gray;
                }
                batch.DrawString(arial, GetItem(i), new Vector2(screenWidth / 2 - arial.MeasureString(GetItem(i)).X / 2, yPos), colour);
                yPos += 50;
            }
        }

        public void DrawEndScreen(SpriteBatch batch, int screenWidth, SpriteFont arial)
        {
            batch.DrawString(arial, InfoText, new Vector2(screenWidth / 2 - arial.MeasureString(InfoText).X / 2, 300), Color.White);
            string prompt = "Press Enter to Continue";
            batch.DrawString(arial, prompt, new Vector2(screenWidth / 2 - arial.MeasureString(prompt).X / 2, 400), Color.White);
        }
    }
}
