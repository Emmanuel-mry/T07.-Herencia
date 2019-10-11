using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args) 
        {
            Paciente PAC = new Paciente();
            Console.WriteLine("PACIENTE:");


            PAC.Id = 253467;
            PAC.Nombre = "Monroy Hernandez Emmanuel";
            PAC.Nacimiento = "25/05/1998";
            PAC.Correo = "emm.monroy25@gmail.com";
            PAC.Telefono = "6645869786";
            Console.WriteLine("ID: " + PAC.Id);
            Console.WriteLine("NOMBRE: " + PAC.Nombre);
            Console.WriteLine("FECHA/NAC: " + PAC.Nacimiento);
            Console.WriteLine("CORREO: "+PAC.Correo);
            Console.WriteLine("TELEFONO: " + PAC.Telefono);
            Console.WriteLine();

            Enfermera ENF = new Enfermera();
            Console.WriteLine("ENFERMERA:");
            ENF.Id = 01023;
            ENF.Nombre = "Velazquez Romero Ana Luisa";
            ENF.Nacimiento = "15/04/1991";
            ENF.Correo = "analuisa53@gmail.com";
            ENF.Telefono = "6646647837";
            ENF.Area = "Odontologia";
            ENF.Horario = "Lunes a Viernes de 8am a 3pm";
            Console.WriteLine("ID: " + ENF.Id);
            Console.WriteLine("NOMBRE: " + ENF.Nombre);
            Console.WriteLine("FECHA/NAC: " + ENF.Nacimiento);
            Console.WriteLine("CORREO: " + ENF.Correo);
            Console.WriteLine("TELEFONO: " + ENF.Telefono);
            Console.WriteLine("AREA: " +ENF.Area);
            Console.WriteLine("HORARIO: "+ENF.Horario);
            Console.WriteLine();
            Console.WriteLine("HOMBRE:");

            Hombre HM = new Hombre();
            
            HM.Nombre = "Monroy Hernandez Emmanuel";
            HM.Nacimiento = "25/05/1998";
            HM.Correo = "emm.monroy25@gmail.com";
            HM.Telefono = "6645869786";
            Console.WriteLine("NOMBRE: " + HM.Nombre);
            Console.WriteLine("FECHA/NAC: " + HM.Nacimiento);
            Console.WriteLine("CORREO: " +HM.Correo);
            Console.WriteLine("TELEFONO: " + HM.Telefono);
            Console.WriteLine();
            Console.WriteLine("MUJER:");
            Mujer MJ = new Mujer();
            
            MJ.Nombre = "Maria Expinoza Lugo";
            MJ.Nacimiento = "25/05/1998";
            MJ.Correo = "maria5@gmail.com";
            MJ.Telefono = "6645868768";
            
            Console.WriteLine("NOMBRE: " + MJ.Nombre);
            Console.WriteLine("FECHA/NAC: " +MJ.Nacimiento);
            Console.WriteLine("CORREO: " + MJ.Correo);
            Console.WriteLine("TELEFONO: " +MJ.Telefono);
            Console.WriteLine();

            Console.WriteLine("MEDICO:");
            Medico MD = new Medico();
            MD.Id = 074637;
            MD.Nombre = "Arturo Mendoza Martinez";
            MD.Nacimiento = "18/09/1986";
            MD.Correo = "doctor7272@gmail.com";
            MD.Telefono = "674783768";
            MD.Area = "Cirujano";
            
            Console.WriteLine("ID: " + MD.Id);
            Console.WriteLine("NOMBRE: " + MD.Nombre);
            Console.WriteLine("FECHA/NAC: " + MD.Nacimiento);
            Console.WriteLine("CORREO: " + MD.Correo);
            Console.WriteLine("TELEFONO: " + MD.Telefono);
            Console.WriteLine("AREA: " + MD.Area);
            Console.WriteLine();
            Console.ReadKey();

        }

    }
}
