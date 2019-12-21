using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNA.Cheques;

namespace persistenciaArchivos.UNA.Cheques
{
    public class ArchivoManager
    {
         
        public List<Cheque> ChequesList { get; set; }

        public ArchivoManager()
        {
            ChequesList = new List<Cheque>();
        }
        public string CrearArchivo(string rutaBase) { 
            string path = $"{DateTime.Now.ToString()}.csv";
            path= path.Replace("/", "_");
            path= path.Replace(":", "_");
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                foreach (Cheque cheque in ChequesList) 
                { 
                    var line =  $"{cheque.Nombre},{cheque.Numero},{cheque.Monto},{cheque.Descripcion}, {cheque.Emisor}, {cheque.Receptor}, {cheque.Fecha}, {cheque.Moneda}, {cheque.InstitucionFinanciera}";
                    streamWriter.WriteLine(line);
                }
                    streamWriter.Flush();
                return path;
            }
        }
        public void CargarCheques(String contraseña) {
            
                String[] nombreDeArquivos =  Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory,"*.csv");

                for (int i = 0; i < nombreDeArquivos.Length ; i++ )
                {
                    using (StreamReader readerFile = new StreamReader(nombreDeArquivos[i]))
                    {
                        string linea;
                        string[] renglon;

                        while ((linea = readerFile.ReadLine()) != null)
                        {
                            renglon = linea.Split(',');

                            //try
                            //{
                                Cheque cheque = new Cheque
                                {
                                    Nombre = renglon[0],
                                    Numero = renglon[1],
                                    Monto = Convert.ToDouble(renglon[2]),
                                    Descripcion = Encriptacion.DesencriptarString(renglon[3], contraseña),
                                    Emisor = renglon[4],
                                    Receptor = renglon[5],
                                    InstitucionFinanciera = renglon[8],
                                    Moneda = renglon[7],
                                    Fecha = Convert.ToDateTime(renglon[6])
                                };
                                ChequesList.Add(cheque);
                            //}
                            //catch(Exception)
                            //{

                            //}
                        }
                    }
                }
            
        }
    }
}
