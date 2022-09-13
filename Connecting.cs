using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Data;
using Operp;
using System.Windows.Forms;

namespace Kupalinka
{
    static public class Connecting
    {
        static int port = 10101;
        static string address = "192.155.11.220";

        static public List<Operaciiposhiva> connect_sql_operaciiposhiva(string message)
        {
            TcpClient client = null;

            try
            {
                client = new TcpClient(address, port);
                NetworkStream stream = client.GetStream();

                byte[] data = Encoding.Unicode.GetBytes(message);
                // отправка сообщения
                stream.Write(data, 0, data.Length);

                // получаем ответ
                data = new byte[16777216]; // буфер для получаемых данных
                          //  StringBuilder builder = new StringBuilder();
                List<Operaciiposhiva> operaciiposhiva = new List<Operaciiposhiva>();
                int bytes;
                do
                {
                    bytes = stream.Read(data, 0, data.Length);
                    BinaryFormatter formatter = new BinaryFormatter();
                    MemoryStream mstream = new MemoryStream(data);
                   // Operaciiposhiva nselect = new Operaciiposhiva();
                    if (data.Length != 0)
                    {
                        operaciiposhiva = (List<Operaciiposhiva>)formatter.Deserialize(mstream);
                        //  lshchet.Add(nselect);
                    }
                }
                while (stream.DataAvailable);

                //   builder.Append(Encoding.Unicode.GetString(data, 0, bytes));

                return operaciiposhiva;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                
                client.Close();
            }
        }


    }
}
