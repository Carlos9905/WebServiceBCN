using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSBCN
{
    public partial class MainForm : Form
    {
        //LLamando al WS del Banco desde el cliente
        WSTC_Dia.Tipo_Cambio_BCNSoapClient tipo_Cambio_BCN = new WSTC_Dia.Tipo_Cambio_BCNSoapClient();        
        public MainForm()
        {
            InitializeComponent();
            cbx_meses.SelectedIndex = 0;//El ComboBox Se inicia en el elemento 0
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void cbx_meses_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Selecion del mes
            switch (cbx_meses.SelectedIndex)
            {
                //Enero
                case 0:
                    dgv_tipoDeCambio.Rows.Clear();//Para que no se sobre escriban los datos
                    XElement enero = tipo_Cambio_BCN.RecuperaTC_Mes(2022, 1);                 
                    IEnumerable<XElement> en = from datos in enero.Descendants("Tc")
                                               orderby int.Parse(datos.Element("Dia").Value)
                                               select datos;

                    foreach (XElement d in en)
                    {
                        int i = dgv_tipoDeCambio.Rows.Add();
                        dgv_tipoDeCambio.Rows[i].Cells[0].Value = d.Element("Dia").Value;
                        dgv_tipoDeCambio.Rows[i].Cells[1].Value = d.Element("Valor").Value;
                        dgv_tipoDeCambio.Rows[i].Cells[2].Value = "Enero";
                    }
                    break;
                //Febrero
                case 1:
                    dgv_tipoDeCambio.Rows.Clear();//Para que no se sobre escriban los datos
                    XElement Febrero = tipo_Cambio_BCN.RecuperaTC_Mes(2022, 2);
                    IEnumerable<XElement> fe = from datos in Febrero.Descendants("Tc")
                                               orderby int.Parse(datos.Element("Dia").Value)
                                               select datos;

                    foreach (XElement d in fe)
                    {
                        int i = dgv_tipoDeCambio.Rows.Add();
                        dgv_tipoDeCambio.Rows[i].Cells[0].Value = d.Element("Dia").Value;
                        dgv_tipoDeCambio.Rows[i].Cells[1].Value = d.Element("Valor").Value;
                        dgv_tipoDeCambio.Rows[i].Cells[2].Value = "Febrero";
                    }
                    break;
                //Marzo
                case 2:
                    dgv_tipoDeCambio.Rows.Clear();//Para que no se sobre escriban los datos
                    XElement Marzo = tipo_Cambio_BCN.RecuperaTC_Mes(2022, 3);
                    IEnumerable<XElement> ma = from datos in Marzo.Descendants("Tc")
                                               orderby int.Parse(datos.Element("Dia").Value)
                                               select datos;

                    foreach (XElement d in ma)
                    {
                        int i = dgv_tipoDeCambio.Rows.Add();
                        dgv_tipoDeCambio.Rows[i].Cells[0].Value = d.Element("Dia").Value;
                        dgv_tipoDeCambio.Rows[i].Cells[1].Value = d.Element("Valor").Value;
                        dgv_tipoDeCambio.Rows[i].Cells[2].Value = "Marzo";
                    }
                    break;                
            }
        }
    }
}
