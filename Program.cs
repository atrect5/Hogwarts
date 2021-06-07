using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using static System.Console;
using System.IO;


namespace Hogwarts_16301106_17100150
{

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

    public class Plantel
    {
        [key]
        [Required]
        public int id_Plantel {set; get;}
        public string clave_Plantel { get; set; }
        [StringLength (50)]
        [Required]
        public string nombre_Plantel { get; set; }
    }
    public class Departamentos
    {
        [key]
        [Required]
        public int id_Depto {set; get;}
        [StringLength (35)]
        [Required]
        public string nombre_Depto { get; set; }
    }
    public class Empleados
    {
         [key]
        [Required]
        public int id_Empleado {set; get;}
        [StringLength (35)]
        [Required]
        public string nombre_Empleado { get; set; }
        [StringLength (20)]
        [Required]
        public string apellido_Paterno { get; set; }
        [StringLength (20)]
        [Required]
        public string apellido_Materno { get; set; }
        [Required]
        public string correo_Empleado { get; set; }
        [Required]
        public string contrasena_Empleado { get; set; }
        public Date fecha_Nacimiento_Empleado { get; set; }
        [Required]
        public Date fecha_Ingreso_Empleado { get; set; }
        [Required]
        public virtual Nomina nomina { get; set; }
        [Required]
        public virtual Plantel plantel { get; set; }
        [Required]
        public virtual Departamentos departamentos { get; set; }
    }
    public class Jefes
    {
        [key]
        [Required]
        public int id_Jefe {set; get;}
        [StringLength (35)]
        [Required]
        public Ststringring nombre_Jefe { get; set; }
        [StringLength (20)]
        [Required]
        public string apellido_Paterno { get; set; }
        [StringLength (20)]
        [Required]
        public string apellido_Materno { get; set; }
        [Required]
        public string correo_Jefe { get; set; }
        [Required]
        public string contrasena_Jefe { get; set; }
        public Date fecha_Nacimiento_Jefe { get; set; }
        [Required]
        public Date fecha_Ingreso_Jefeo { get; set; }
        [Required]
        public virtual Nomina nomina { get; set; }
        [Required]
        public virtual Plantel plantel { get; set; }
        [Required]
        public virtual Departamentos departamentos { get; set; }
    }
    public class Nomina
    {
        [key]
        [Required]
        public string id_Nomina { get; set; }
        [Required]
        public int numero_Nomina { get; set; }
    }
    public class Permisos
    {
        [Key]
        [Required]
        public int id_Permiso { get; set; }
        [Required]
        [StringLength (15)]
        public string tipo_Permiso { get; set; }
        [Required]
        [StringLength (15)]
        public string proceso_Permiso { get; set; }
        [Required]
        [StringLength (150)]
        public string motivo_Permiso { get; set; }
        [Required]
        public Date fecha_inicio { get; set; }
        public Date fecha_Fin { get; set; }
        public Empleados empleados { get; set; }
        public Jefes jefes { get; set; }

    }
    public class Recuperacion
    {
        [Key]
        [Required]
        public int id_Recuperacion { get; set; }
        public int random_Recuperacion { get; set; }
        public Empleados empleados { get; set; }
        public Jefes jefes { get; set; }
    }

    
}
