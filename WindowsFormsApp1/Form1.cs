using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ListViewItem listViewItem = new ListViewItem();
			listViewItem.Text = textBox1.Text;
			listViewItem.SubItems.Add(textBox2.Text);
			listViewItem.SubItems.Add(textBox3.Text);
			listViewItem.SubItems.Add(textBox4.Text);
			this.listView1.Items.Add(listViewItem);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in this.listView1.SelectedItems)
			{
				this.listView1.Items.Remove(item);
			}
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{
			Console.WriteLine("ok");
		}

		private void label7_Click(object sender, EventArgs e)
		{
			Console.WriteLine("good");
		}
	}
}
