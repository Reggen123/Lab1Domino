using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prog2Lab1;

namespace DominoLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_MouseClick(object sender, MouseEventArgs e)
        {
            DominoValues Number1 = (DominoValues)numericUpDown1.Value;
            DominoValues Number2 = (DominoValues)numericUpDown2.Value;
            Domino domino = new Domino(Number1, Number2);
            listBox1.Items.Add(domino);
            DominoId.Maximum = listBox1.Items.Count-1;
        }

        private void buttonMakeTurn_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem == null || listBox1.Items.IndexOf(listBox1.SelectedItem) == (int)DominoId.Value)
            {
                labelResult.Text = "Выберите один";
                return;
            }

            Domino dom1 = (Domino)listBox1.Items[(int)DominoId.Value];
            Domino dom2 = (Domino)listBox1.SelectedItem;

            if(dom1.MakeTurn(dom2))
            {
                labelResult.Text = "Все прошло успешно";
            }
            else
            {
                labelResult.Text = "Так себе";
            }
        }

        private void buttonGetNumbers_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;
            Domino dom = (Domino)listBox1.SelectedItem;
            labelValues.Text = dom.ReturnDominoValuesString();
        }
    }
}
