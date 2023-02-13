using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using prueba.Data;
using prueba.Models;
using System.Data;

namespace prueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        [HttpGet]
        public dynamic listarUsuarios()
        {
          DataTable tUsuarios =  DatabaseDatos.Listar("SP_CargarUsuarios");
            string jsonUsuarios = JsonConvert.SerializeObject(tUsuarios);
            return JsonConvert.DeserializeObject<List<Usuario>>(jsonUsuarios);
        }

    }
}
