using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoETO
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            #region Text
            Label infOfBubble = new Label();
            Label header = new Label();
            Label gifHeader = new Label();       
            infOfBubble.AutoSize = true;
            gifHeader.AutoSize = true;
            infOfBubble.Location = new Point(1, 31);
            gifHeader.Location = new Point(1, 160);
            header.Location = new Point(1, 1);
            header.Size = new Size(500, 30);
            header.Font = new Font("Arial", 18f, FontStyle.Bold);
            header.Text = "Сортування методом бульбашки";            
            infOfBubble.Text = "Cортування бульбашкою є простим алгоритмом сортування.\nАлгоритм працює таким чином — у поданому наборі даних (списку чи масиві) порівнюються два сусідні елементи.\nЯкщо один з елементів, не відповідає критерію сортування (є більшим, або ж, навпаки, меншим за свого сусіда),\nто ці два елементи міняються місцями. Прохід по списку продовжується до тих пір, доки дані не будуть відсортованими.\nАлгоритм отримав свою назву від того, що процес сортування за ним нагадує поведінку бульбашок повітря у резервуарі з водою.\nОскільки для роботи з елементами масиву він використовує лише порівняння, це сортування на основі порівнянь.\nСкладність алгоритму:O(n^2). Алгоритм вважається навчальним і практично не застосовується у не навчальних цілях,\nзамість нього на практиці застосовують більш ефективні алгоритми сортування.";
            gifHeader.Font = new Font("Arial", 18f, FontStyle.Bold);
            gifHeader.Text = "Візуалізація роботи алгоритму сортування бульбашкою";
            Controls.Add(gifHeader);
            Controls.Add(infOfBubble);
            Controls.Add(header);
            #endregion
            #region Gif Animation
            PictureBox lol = new PictureBox();lol.Image = Image.FromFile("C:/Users/Vanya/Desktop/All/Android/Kurs/Bubble.gif");
            lol.Location = new Point(1, 180);
            lol.Size = new Size(277, 257);
            Controls.Add(lol);
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            this.Size = new Size(800, 500);
        }
    }
}
