using BarraBuscadoraMvcTutorial.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarraBuscadoraMvcTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public string ConsultarAtletas()
        {
            List<Atleta> atletas = new List<Atleta>();
            DataTable dt = new DataTable();
            Respuesta_Json respuesta = new Respuesta_Json();

            using(SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Tutoriales"].ToString()))
            {
                try
                {
                    string query = "SELECT [Id],[Nombre_Atleta],[Pais_Origen],[Marca],[Lugar_Marca],[Anio_Marca] FROM [Tutoriales].[dbo].[Atletas]";
                    using(SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.Text;
                        dt.Load(cmd.ExecuteReader());
                    }

                    foreach (DataRow fila in dt.Rows)
                    {
                        Atleta atleta = new Atleta()
                        {
                            Id = Convert.ToInt32(fila["Id"]),
                            Anio_Marca = Convert.ToInt32(fila["Anio_Marca"]),
                            Lugar_Marca = fila["Lugar_Marca"].ToString(),
                            Marca = fila["Marca"].ToString(),
                            Pais_Origen = fila["Pais_Origen"].ToString(),
                            Nombre_Atleta = fila["Nombre_Atleta"].ToString(),

                            //Id = !DBNull.Value.Equals(fila["Id"]) ? Convert.ToInt32(fila["Id"]) : 0,
                            //Lugar_Marca = !DBNull.Value.Equals(fila["Lugar_Marca"]) ? fila["Lugar_Marca"].ToString() : "",

                        };
                        atletas.Add(atleta);
                    }

                    //Todo funcionó correctamente
                    respuesta.Codigo = 1;
                    respuesta.Mensaje = "Atletas Consultados correctamente";
                    respuesta.Data = atletas;

                }catch(Exception ex)
                {
                    //ocurrió algún error
                    respuesta.Codigo = 0;
                    respuesta.Mensaje = "Ocurrió un error en el servidor" + ex.ToString();
                }
                finally
                {
                    cnn.Close();
                    cnn.Dispose();
                }
            }

            return JsonConvert.SerializeObject(respuesta);
        }
    }
}