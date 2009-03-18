/*
 * Created by SharpDevelop.
 * User: diaz60844
 * Date: 3/3/2009
 * Time: 5:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Negocio;
namespace POSinnovic
{
	/// <summary>
	/// Description of CierreVenta.
	/// </summary>
	public partial class CierreVenta : Form
	{
		public DataGridView dtgv;
		public negocio Neg;
		public Int32 Total;
		public Descuentos Desc;

		public CierreVenta()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void CierreVentaLoad(object sender, EventArgs e)
		{
			negocio neg            = this.Neg;
			MySqlDataReader reader = neg.select("Select * from pos_formas_pago");
				
			dataGridView1.Columns[0].ReadOnly=true;
			dataGridView1.Columns[1].ReadOnly=false;
			while(reader.Read()){
				dataGridView1.Rows.Add();
				dataGridView1.Rows[dataGridView1.Rows.Count-1].Cells[0].Value = reader["Descripcion"].ToString();
			}
			neg.cerrar();
			textBox1.Text = this.Total.ToString();
			CalcTotal()			;
		}
		
		void DataGridView1KeyDown(object sender, KeyEventArgs e)
		{
			
			switch(e.KeyCode){
					case Keys.Back:
						dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value = "";
						CalcTotal();
						break;
					case Keys.Delete:
					case Keys.Down:
					case Keys.Up:
					case Keys.Left:
					case Keys.Right:
					case Keys.Clear:
					case Keys.Alt:
					case Keys.Control:
					case Keys.Shift:
					case Keys.PageDown:
					case Keys.PageUp:
					case Keys.End:
					case Keys.Home:
					case Keys.Subtract:
					case Keys.OemMinus:
					case Keys.Add:
					case Keys.Oemplus:
					case Keys.Escape:
					case Keys.Enter:
					case Keys.F2:
					case Keys.F3:
					case Keys.F4:
					case Keys.F5:
					case Keys.F6:
					case Keys.F7:
					case Keys.F8:
					default:
						try{
						
							string car = e.KeyCode.ToString();
							if ((car.Length==2 && car.Substring(0,1).Equals("D")) ){
								car = car.Substring(1,1);
							}else{
								if (car.IndexOf("NumPad") > -1){
									car=car.Substring(6,1);
								}
							}
							
							int keyint = (int)Convert.ToChar(car);
							if (keyint >= 48 && keyint <= 57){
								dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1];								
								SendKeys.Flush();
								SendKeys.Send(car);
							}
						
						}catch(System.FormatException err){
							err.ToString();
						}
						break;
			}
			
		}
		
		void CierreVentaKeyDown(object sender, KeyEventArgs e)
		{
			switch(e.KeyCode){
				case Keys.Enter:
					CalcTotal();
					break;
				case Keys.F5:
					FormDescuento FRD = new FormDescuento();
					FRD.Descuento     = this.Desc;
					FRD.Cierre        = this;
					FRD.Tipo          = 2;
					FRD.Show();
					break;
				case Keys.F7:
					dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value = textBox6.Text;
					break;
				case Keys.F3:
					impresion imp = new impresion();
					imp.gentxt(1);
					break;
					
			}
		}
		
		public void CalcTotal(){
			int largo        = dataGridView1.Rows.Count;
			Int32 TotalPagos = 0;
			Int32 Total      = 0;
			Int32 Resta      = 0;
			for(int t=0; t<largo; t++){
				try{
					TotalPagos += Int32.Parse(dataGridView1.Rows[t].Cells[1].Value.ToString());
				}catch(Exception e){
					e.ToString();
				}
			}
			textBox3.Text = (this.Desc.GetDesctoTotImp()*-1).ToString();
			textBox2.Text = "-"+(Single.Parse(textBox1.Text) * (this.Desc.GetDesctoTotPor()/100)).ToString();
			label2.Text= "Descuento   "+this.Desc.GetDesctoTotPor().ToString()+"%";
			Total        += Convert.ToInt32( Single.Parse(textBox1.Text)+Single.Parse(textBox2.Text)+Single.Parse(textBox3.Text));
			textBox4.Text = Total.ToString();
			textBox5.Text = TotalPagos.ToString();
			Resta         = (Total - TotalPagos);
			if (Resta < 0){
				textBox6.Text = "0";
				textBox7.Text = (Resta*-1).ToString();
			}else{
				textBox6.Text = (Resta).ToString();
				textBox7.Text = "0";
			}
			
		}
		
		void DataGridView1CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			CalcTotal();
		}
	}
}