using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Windows.Forms;
using System.Data;

namespace ClassDato
{
  public  class clsConexiones
    {

        public static MySqlConnection cnx = new MySqlConnection("server=127.0.0.1; database=DB_Ventas; Uid=root; pwd=;");



        public static void EjecutaQuery( string Opcion)
        {
            

            
            MySqlCommand cmd = new MySqlCommand();

            
            switch (Opcion)
            {

                case "RP":
                    cmd = new MySqlCommand($"INSERT INTO `producto`(`NombreProducto`, `Precio`) VALUES ('{ClassBT.clsProducto.NombreProducto}',{ClassBT.clsProducto.Precio})", cnx);
                    break;

                case "RV":
                    cmd = new MySqlCommand($"INSERT INTO `ventas`( `Fecha`, `Costo`) VALUES ('{ClassBT.clsVenta.Fecha}',{ClassBT.clsVenta.Costo})", cnx);
                    break;

                case "RDV":
                    cmd = new MySqlCommand($"INSERT INTO `detallaventa`( `idProductofk`, `Cantidad`, `Costo`, `idVentas`) VALUES ({ClassBT.clsDetallesVenta.idProdcutofk},{ClassBT.clsDetallesVenta.Cantidad},{ClassBT.clsDetallesVenta.CostoDetalle},{ClassBT.clsDetallesVenta.IdVentafk})", cnx);
                    break;

            }
            
             try
            {
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                
            }
            catch (Exception e)
            {

                MessageBox.Show("ERROR: "+e);
            }

        }
        public static DataTable EjecutaQueryConsulta(string Dato,string Opcion)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();


            switch (Opcion)
            {

                case "C":
                    da = new MySqlDataAdapter("SELECT * FROM `producto` ", cnx);
                    break;

            }
            switch (Opcion)
            {

                case "IDV":
                    da = new MySqlDataAdapter("SELECT MAX( `idVenta`) FROM `ventas`", cnx);
                    break;

            }

            switch (Opcion)
            {

                case "CDV":
                    da = new MySqlDataAdapter("SELECT `idVenta`, `Fecha`, V.Costo,`idProducto`, `NombreProducto`, `Precio`,`idDetalleventa`, `idProductofk`, `Cantidad`,dv.Costo FROM ventas as V , producto as p,detallaventa as dv WHERE idVenta=dv.idVentas and idProducto=idProductofk", cnx);
                    break;

            }
            try
            {
                cnx.Open();
                da.Fill(dt);
                cnx.Close();
               
            }
            catch (Exception e)
            {

                MessageBox.Show("ERROR: " + e);
            }

            return dt;

        }

    }
}
