using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        RadioButton rad;
        TextBox txt;
        PictureBox pic;
        TabControl tab;
        MessageBox msg;
        int t = 0;

        public Form1()
        {

            this.Height = 500;
            this.Width = 700;
            this.Text = "4 Elements";
            this.BackColor = Color.LightCoral;
            this.ForeColor = Color.LightSalmon;

            tree = new TreeView();
            tree.Dock = DockStyle.Right;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode tn = new TreeNode("Elements");
            tn.Nodes.Add(new TreeNode("Button"));
            tn.Nodes.Add(new TreeNode("Label"));
            tn.Nodes.Add(new TreeNode("PictureBox"));
            tn.Nodes.Add(new TreeNode("Checkbox"));
            tn.Nodes.Add(new TreeNode("Radiobutton"));
            tn.Nodes.Add(new TreeNode("Textbox"));
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
            lbl.Size = new Size(100, 25);
            lbl.Location = new Point(215, 25);

            pic = new PictureBox();
            pic.ImageLocation = "../../img/5-cell.gif";//Image=Image.FromFile(@"../../5-cell.gif")
            pic.SizeMode= PictureBoxSizeMode.StretchImage;
            pic.Size = new Size(100,100);
            pic.Location = new Point(80, 70);
            pic.DoubleClick += Pic_DoubleClick;

            check = new CheckBox();
            check.Size = new Size(25, 25);
            check.Location = new Point(160, 60);

            tree.Nodes.Add(tn);
            this.Controls.Add(tree);
        }

        private void Pic_DoubleClick(object sender, EventArgs e)
        {
            string[] img = {"flower.jpg","earth.png", "5-cell.gif" };
            pic.ImageLocation ="../../img/"+ img[t];//Image=Image.FromFile(@"../../5-cell.gif")
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
            butt.Text = "I lied, Life is a lie";
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
            }
        }
    }
}
