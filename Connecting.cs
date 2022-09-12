using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Data;

namespace Kupalinka
{
    static public class Connecting
    {
        static int port = 10101;
        static string address = "192.155.11.220";

        static public void connect(string message)
        {
            TcpClient client = null;

            try
            {
                client = new TcpClient(address, port);
                NetworkStream stream = client.GetStream();

                List<select_lsh.select_lsh> lshchet = new List<select_lsh.select_lsh>();
                byte[] data = Encoding.Unicode.GetBytes(richTextBox1.Text);
                // отправка сообщения
                stream.Write(data, 0, data.Length);

                // получаем ответ
                data = new byte[16777216]; // буфер для получаемых данных
                StringBuilder builder = new StringBuilder();
                int bytes;
                do
                {
                    bytes = stream.Read(data, 0, data.Length);
                    BinaryFormatter formatter = new BinaryFormatter();
                    MemoryStream mstream = new MemoryStream(data);
                    select_lsh.select_lsh nselect = new select_lsh.select_lsh();
                    if (data.Length != 0)
                    {
                        lshchet = (List<select_lsh.select_lsh>)formatter.Deserialize(mstream);
                        //  lshchet.Add(nselect);
                    }

                }
                while (stream.DataAvailable);

                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));

            }
            catch (Exception ex)
            {
             //   richTextBox1.Text += ex.Message;
            }
            finally
            {
                client.Close();
            }
        }


    }
}
