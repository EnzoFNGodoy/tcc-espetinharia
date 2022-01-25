using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espetinho_TCC.Utils
{
    class BackupBD
    {
        public string data, file;

        public void backup()
        {
            string constring = "SERVER = localhost; DATABASE = Espetinho; UID = root; PWD = godoy; PORT = 3306;";

            constring += "charset=utf8;convertzerodatetime=true;";
            data = DateTime.Now.ToString("dd-MM-yyyy-HH-mm");
            file = "backup/backup-" + data + ".sql";

            using (MySqlConnection conexaoString = new MySqlConnection(constring))
            {
                using (MySqlCommand comando = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(comando))
                    {
                        comando.Connection = conexaoString;
                        conexaoString.Open();
                        mb.ExportToFile(file);
                        conexaoString.Close();
                    }
                }
            }
        }
    }
}
