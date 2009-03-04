﻿/*
 * Created by SharpDevelop.
 * User: diaz60844
 * Date: 2/18/2009
 * Time: 10:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace POSinnovic
{
	partial class POS
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.CANT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CODART = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PreUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.CANT,
									this.CODART,
									this.Desc,
									this.PreUnit,
									this.Total});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.InactiveCaption;
			this.dataGridView1.Location = new System.Drawing.Point(12, 89);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(1075, 396);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellLeave);
			this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1KeyDown);
			// 
			// CANT
			// 
			dataGridViewCellStyle2.Format = "N0";
			this.CANT.DefaultCellStyle = dataGridViewCellStyle2;
			this.CANT.FillWeight = 16.94383F;
			this.CANT.HeaderText = "CANT";
			this.CANT.MaxInputLength = 3;
			this.CANT.Name = "CANT";
			this.CANT.ReadOnly = true;
			// 
			// CODART
			// 
			this.CODART.FillWeight = 20.30457F;
			this.CODART.HeaderText = "CODIGO ARTICULOS";
			this.CODART.MaxInputLength = 13;
			this.CODART.Name = "CODART";
			this.CODART.ReadOnly = true;
			// 
			// Desc
			// 
			this.Desc.FillWeight = 46.8573F;
			this.Desc.HeaderText = "DESCRIPCION";
			this.Desc.Name = "Desc";
			this.Desc.ReadOnly = true;
			// 
			// PreUnit
			// 
			this.PreUnit.FillWeight = 7.881869F;
			this.PreUnit.HeaderText = "PRECIO UNITARIO";
			this.PreUnit.Name = "PreUnit";
			this.PreUnit.ReadOnly = true;
			// 
			// Total
			// 
			this.Total.FillWeight = 8.01245F;
			this.Total.HeaderText = "TOTAL";
			this.Total.Name = "Total";
			this.Total.ReadOnly = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(381, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "18 Feb 2009";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "11:05 AM";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(987, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "WINNPos V1.0";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(988, 31);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(99, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "INNOVIC";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(118, 63);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 7;
			this.label7.Text = "Vendedor";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(880, 62);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 8;
			this.label8.Text = "OPE";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label10.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(831, 488);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(250, 51);
			this.label10.TabIndex = 10;
			this.label10.Text = "$99.999.999";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
			this.label11.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(744, 488);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(81, 51);
			this.label11.TabIndex = 11;
			this.label11.Text = "TOTAL";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label12.Location = new System.Drawing.Point(743, 483);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(344, 59);
			this.label12.TabIndex = 12;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(555, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(183, 75);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(12, 483);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(730, 59);
			this.panel1.TabIndex = 17;
			// 
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.Location = new System.Drawing.Point(641, 4);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(85, 52);
			this.button8.TabIndex = 31;
			this.button8.Text = "FIN ESC";
			this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button8.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(550, 4);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(85, 52);
			this.button7.TabIndex = 30;
			this.button7.Text = "OTRAS \r\nF8";
			this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button7.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(459, 4);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(85, 52);
			this.button6.TabIndex = 29;
			this.button6.Text = "PESA \r\nF7";
			this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(368, 4);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(85, 52);
			this.button5.TabIndex = 28;
			this.button5.Text = "RECOL \r\nF6";
			this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Yellow;
			this.button4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(277, 4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(85, 52);
			this.button4.TabIndex = 27;
			this.button4.Text = "DESCU \r\nF5";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Teal;
			this.button3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(186, 4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(85, 52);
			this.button3.TabIndex = 26;
			this.button3.Text = "CANCEL\r\nF4";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Red;
			this.button2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(95, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(85, 52);
			this.button2.TabIndex = 25;
			this.button2.Text = "TOTAL\r\nF3";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 52);
			this.button1.TabIndex = 24;
			this.button1.Text = "BUSCA \r\nF2";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// POS
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(1099, 636);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label12);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "POS";
			this.Text = "POS";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Activated += new System.EventHandler(this.POSActivated);
			this.Resize += new System.EventHandler(this.POSResize);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.POSKeyDown);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Total;
		private System.Windows.Forms.DataGridViewTextBoxColumn PreUnit;
		private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
		private System.Windows.Forms.DataGridViewTextBoxColumn CODART;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANT;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}
