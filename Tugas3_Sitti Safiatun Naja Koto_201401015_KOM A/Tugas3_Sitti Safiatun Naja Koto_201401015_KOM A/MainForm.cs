/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 2/26/2022
 * Time: 1:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tugas3_Sitti_Safiatun_Naja_Koto_201401015_KOM_A
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			comboBox1.Items.Add("Medan");
			comboBox1.Items.Add("Padang");
			comboBox1.Items.Add("Jakarta");
			comboBox1.Items.Add("Bandung");
			comboBox1.Items.Add("Bali");
			comboBox2.Items.Add("Ekonomi");
			comboBox2.Items.Add("Bisnis");
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			string kota =(string)comboBox1.SelectedItem;
			waktu(kota);
		}
		
		void waktu (string kota)
		{
			listBox1.Items.Clear();
			listBox1.SelectionMode=SelectionMode.MultiSimple;
			if (kota== "Medan")
			{
				listBox1.Items.Add("08.00");
				listBox1.Items.Add("10.20");
				listBox1.Items.Add("13.55");
				listBox1.Items.Add("16.55");
				listBox1.Items.Add("20.00");
			}
			else if (kota== "Padang")
			{
				listBox1.Items.Add("08.00");
				listBox1.Items.Add("10.20");
				listBox1.Items.Add("13.55");
				listBox1.Items.Add("16.55");
				listBox1.Items.Add("20.00");
			}
			else if (kota== "Jakarta")
			{
				listBox1.Items.Add("08.00");
				listBox1.Items.Add("10.20");
				listBox1.Items.Add("13.55");
				listBox1.Items.Add("16.55");
				listBox1.Items.Add("20.00");
			}
			else if (kota== "Bandung")
			{
				listBox1.Items.Add("08.00");
				listBox1.Items.Add("10.20");
				listBox1.Items.Add("13.55");
				listBox1.Items.Add("16.55");
				listBox1.Items.Add("20.00");
			}
			else if (kota== "Bali")
			{
				listBox1.Items.Add("08.00");
				listBox1.Items.Add("10.20");
				listBox1.Items.Add("13.55");
				listBox1.Items.Add("16.55");
				listBox1.Items.Add("20.00");
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show("(Pendaftaran Berhasil Disimpan)","(Simpan)", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
