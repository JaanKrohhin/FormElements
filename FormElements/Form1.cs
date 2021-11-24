using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormElements
{
    public partial class Form1 : Form
    {
        TreeView tree;
        Button butt;
        Label lbl;
        CheckBox check;
        CheckBox check2;
        CheckBox check3;
        CheckBox check4;
        CheckBox check5;
        RadioButton rad;
        RadioButton rad2;
        TextBox txt;
        PictureBox pic;
        TabControl tab;
        TabPage tabpage;
        Label lbl2;
        TabPage tabpage2;
        Label lbl3;
        TabPage tabpage3;
        Label lbl4;
        int t = 0;
        int t2 = 0;

        public Form1()
        {

            this.Height = 500;
            this.Width = 700;
            this.Text = "4 Elements";
            this.BackColor = Color.LightCoral;
            this.ForeColor = Color.Black;
            this.Font = new Font("Arial", 12);
            this.Icon = Properties.Resources.rb;
            tree = new TreeView();
            tree.Width = 150;
            tree.Dock = DockStyle.Right;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode tn = new TreeNode("Elements");
            tn.Nodes.Add(new TreeNode("Button"));
            tn.Nodes.Add(new TreeNode("Label"));
            tn.Nodes.Add(new TreeNode("PictureBox"));
            tn.Nodes.Add(new TreeNode("CheckBox"));
            tn.Nodes.Add(new TreeNode("RadioButton"));
            tn.Nodes.Add(new TreeNode("TextBox"));
            tn.Nodes.Add(new TreeNode("TabControl"));
            tn.Nodes.Add(new TreeNode("MessageBox"));

            butt = new Button();
            butt.Text = "Free candy, just click here";
            butt.Location = new Point(60,7);
            butt.Height = 50;
            butt.Width = 150;
            butt.BackColor = Color.LightCyan;
            butt.Click += Butt_Click;
            butt.FlatAppearance.BorderSize = 0;

            lbl = new Label();
            lbl.Text = "The button lies";
            lbl.MouseHover += Lbl_MouseHover;
            lbl.MouseLeave += Lbl_MouseLeave;
            lbl.Size = new Size(150, 25);
            lbl.Location = new Point(215, 25);

            pic = new PictureBox();
            pic.ImageLocation = "../../Resources/5-cell.gif";//Image=Image.FromFile(@"../../5-cell.gif")
            pic.SizeMode= PictureBoxSizeMode.StretchImage;
            pic.Size = new Size(100,100);
            pic.Location = new Point(80, 70);
            pic.DoubleClick += Pic_DoubleClick;

            check = new CheckBox();
            check.Size = new Size(150, 25);
            check.Location = new Point(190, 85);
            check.Text = "Rick";
            check.Click += Check_Click;

            check2 = new CheckBox();
            check2.Size = new Size(150, 25);
            check2.Location = new Point(190, 120);
            check2.Text = "2";
            check2.Click += Check2_Click;

            check3 = new CheckBox();
            check3.Size = new Size(150, 25);
            check3.Location = new Point(190, 155);
            check3.Text = "3";
            check3.Click += Check3_Click;

            check4 = new CheckBox();
            check4.Size = new Size(150, 25);
            check4.Location = new Point(190, 190);
            check4.Text = "4";
            check4.Click += Check4_Click;

            check5 = new CheckBox();
            check5.Size = new Size(150, 25);
            check5.Location = new Point(190, 225);
            check5.Text = "5";
            check5.Click += Check5_Click;

            rad = new RadioButton();
            rad.Size = new Size(40, 25);
            rad.Location = new Point(150, 190);
            rad.Text = "1";
            rad.Click += Rad_Click; ;

            rad2 = new RadioButton();
            rad2.Size = new Size(40, 25);
            rad2.Location = new Point(150, 225);
            rad2.Text = "2";
            rad2.Click += Rad_Click2; ;

            txt = new TextBox();
            txt.Size = new Size(75,25);
            txt.Location = new Point(70,225);
            txt.Font = new Font("Georgia",12);

            tab = new TabControl();
            tab.Location = new Point(70,260);
            tabpage = new TabPage("Tab1");
            lbl2 = new Label();
            lbl2.Text = "MEEEOWW";
            lbl2.MouseHover += Lbl_MouseHover;
            lbl2.MouseLeave += Lbl_MouseLeave;
            tabpage.Controls.Add(lbl2);
            tabpage2 = new TabPage("Tab2");
            lbl3 = new Label();
            lbl3.Text = "Rawr";
            lbl3.MouseHover += Lbl_MouseHover;
            lbl3.MouseLeave += Lbl_MouseLeave;
            tabpage2.Controls.Add(lbl3);
            tabpage3 = new TabPage("Tab3");
            lbl4 = new Label();
            lbl4.Text = "tabs, kekw";
            lbl4.MouseHover += Lbl_MouseHover;
            lbl4.MouseLeave += Lbl_MouseLeave;
            tabpage3.Controls.Add(lbl4);


            tab.Controls.Add(tabpage);
            tab.Controls.Add(tabpage2);
            tab.Controls.Add(tabpage3);
            tree.Nodes.Add(tn);
            this.Controls.Add(tree);
        }

        private void Rad_Click(object sender, EventArgs e)
        {
            tree.BackColor = Color.Black;
            tree.ForeColor = Color.White;
        }
        private void Rad_Click2(object sender, EventArgs e)
        {
            tree.BackColor = Color.White;
            tree.ForeColor = Color.Black;
        }


        private void Check5_Click(object sender, EventArgs e)
        {
            if (t2 == 1)
            {
                t2 = 0;
                lbl.Text = "The cake is a lie";
            }
            else
            {
                t2 += 1;
                lbl.Text = "The button lies";
            }
        }

        private void Check4_Click(object sender, EventArgs e)
        {
            if (t2 == 1)
            {
                t2 = 0;
                this.Size = new Size(700, 500);
            }
            else
            {
                t2 += 1;
                this.Size = new Size(900, 700);
            }
        }

        private void Check3_Click(object sender, EventArgs e)
        {
            if (t2 == 1)
            {
                t2 = 0;
                this.Text = "4 Elements";
            }
            else
            {
                t2 += 1;
                this.Text = "Yeeet";
            }
        }

        private void Check2_Click(object sender, EventArgs e)
        {
            if (t2 == 1)
            {
                t2 = 0;
                this.BackColor = Color.LightCoral;
            }
            else
            {
                t2 += 1;
                this.BackColor = Color.LightSalmon;
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        private void Pic_DoubleClick(object sender, EventArgs e)
        {
            string[] img = {"flower.jpg","earth.png", "5-cell.gif" };
            pic.ImageLocation = "../../Resources/" + img[t];//Image=Image.FromFile(@"../../5-cell.gif")    ImageLocation = "../../Resouces/" + img[t];
            if (t==img.Length-1)
            {
                t = 0;
            }
            else
            {
                t += 1;
            }
        }

        private void Lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl.BackColor = Color.Transparent;
        }

        private void Lbl_MouseHover(object sender, EventArgs e)
        {
            lbl.BackColor = Color.White;
        }

        private void Butt_Click(object sender, EventArgs e)
        {
            if (txt.Text=="Secret")
            {
                butt.Text = "Secret Acquired";
            }
            else
            {
                butt.Text = "I lied, Life is a lie";
            }

        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text=="Button")
            {
                this.Controls.Add(butt);
            }
            else if (e.Node.Text=="Label")
            {
                this.Controls.Add(lbl);
            }
            else if (e.Node.Text == "PictureBox")
            {
                this.Controls.Add(pic);
            }
            else if (e.Node.Text == "CheckBox")
            {
                this.Controls.Add(check);
                this.Controls.Add(check2);
                this.Controls.Add(check3);
                this.Controls.Add(check4);
                this.Controls.Add(check5);
            }
            else if (e.Node.Text == "RadioButton")
            {
                this.Controls.Add(rad);
                this.Controls.Add(rad2);
            }
            else if (e.Node.Text == "TabControl")
            {
                this.Controls.Add(tab);
            }
            else if (e.Node.Text == "TextBox")
            {
                this.Controls.Add(txt);
            }

            else if (e.Node.Text == "MessageBox")
            {
                MessageBox.Show("MessageBox", "Just your everyday box of messages");
                var answer = MessageBox.Show("Do you love being sick?", "Achoo", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    string text = Interaction.InputBox("WTF dude, why?", "InputBox of confusion", "I am just messing with you");
                    if (MessageBox.Show("Do you want your answer to be show to everyone?", "SHAME", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        lbl.Text = text;
                        Controls.Add(lbl);
                    }
                    else
                    {
                        MessageBox.Show("......no answer, DAMN IT!", "Firetruck");

                    }
                }
                else
                {
                    MessageBox.Show("Whew, I thought you might be some psycho", "Noice");
                }
            }
        }
    }
}
