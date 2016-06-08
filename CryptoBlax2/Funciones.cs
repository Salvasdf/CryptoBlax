using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBlax2
{
    class Funciones
    {

        public string getFileSize(string ruta)
        {

            var bytes = new FileInfo(ruta).Length;
            if (bytes >= 0x1000000000000000) { return ((double)(bytes >> 50) / 1024).ToString("0.### EB"); }
            if (bytes >= 0x4000000000000) { return ((double)(bytes >> 40) / 1024).ToString("0.### PB"); }
            if (bytes >= 0x10000000000) { return ((double)(bytes >> 30) / 1024).ToString("0.### TB"); }
            if (bytes >= 0x40000000) { return ((double)(bytes >> 20) / 1024).ToString("0.### GB"); }
            if (bytes >= 0x100000) { return ((double)(bytes >> 10) / 1024).ToString("0.### MB"); }
            if (bytes >= 0x400) { return ((double)(bytes) / 1024).ToString("0.###") + " KB"; }
            return bytes.ToString("0 Bytes");
        }
        public long getBytes(string ruta)
        {
            return new FileInfo(ruta).Length;
        }

        public bool isPassValid(string pass1, string pass2)
        {
            bool verf = false;

            if(pass1==pass2)
            {
                verf = true;
            }

            return verf;
        }
        public int passSecurity(string pass)
        {
            int security = 0;
            //Largo mínimo de 6 carácteres, 2 puntos por cada carácter adicional
            //4 puntos si incluye mayúsculas
            //5 puntos si contiene carácteres distintos a letras y números
            //2 puntos si contiene números y letras
            bool numero = false;
            bool mayus = false;
            bool largo = false;
            int larg = pass.Length;
            bool letra = false;
            bool especial = false;
            foreach(char cc in pass.ToCharArray())
            {

                if (larg >= 6) { 
                    largo = true;
                }

                if (!numero)
                {
                    if (Char.IsNumber(cc))
                {
                        //es número
                        numero = true;

                }
                }
                if(!letra)
                {
                    if(Char.IsLetter(cc))
                    {
                        letra = true;
                    }
                }

                if(!mayus)
                {
                    if(Char.IsUpper(cc))
                    {
                        mayus = true;
                    }
                }
                if(!especial)
                {
                    if ((Char.IsNumber(cc) == false) && (Char.IsLetter(cc) == false))
                        {
                        especial = true;
                    }
                }

            }

            //Sumar todo
            if(mayus)
            {
                security += 4;
            }
            if(especial)
            {
                security += 5;
            }
            if(numero && letra)
            {
                security += 2;
            }
            if(largo)
            {
                if(larg>6)
                {
                    security += (larg - 6) * 2;
                }
            }
            else
            {
                return 0;
            }

            return security;
        }
        public string CryptoCreateHash(string password, int iterations)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[512]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000*iterations);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            return savedPasswordHash;
        }
        public bool CheckCryptoPass(string username, string password)
        {
            bool verf = false;
            if (username.Length > 0 && password.Length > 0)
            {
                try
                {
                    /* Fetch the stored value */
                    string savedPasswordHash = getHash(username);
                    /* Extract the bytes */
                    byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
                    /* Get the salt */
                    byte[] salt = new byte[16];
                    Array.Copy(hashBytes, 0, salt, 0, 16);
                    /* Compute the hash on the password the user entered */
                    var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
                    byte[] hash = pbkdf2.GetBytes(20);
                    /* Compare the results */
                    for (int i = 0; i < 20; i++)
                        if (hashBytes[i + 16] != hash[i])
                        {
                            return verf;

                        }
                    verf = true;

                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {

                verf = false;
            }
            return verf;


        }

        private string getHash(string username)
        {
            string hash = "";
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=cryptoblax;UID=root;Password=1234"))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("select password from usuarios where username=@p1", connection))
                {
                    cmd.Parameters.AddWithValue("@p1", username);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        StringBuilder sb = new StringBuilder();
                        while (reader.Read())
                            if (reader.FieldCount > 0)
                            {

                                hash = reader.GetString(0);

                            }
                            else
                            {
                                hash = "";
                            }

                    }
                }

            }
            return hash;
        }

        public string getPublicIP()
        {
            string url = "http://checkip.dyndns.org";
            System.Net.WebRequest req = System.Net.WebRequest.Create(url);
            System.Net.WebResponse resp = req.GetResponse();
            System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
            string response = sr.ReadToEnd().Trim();
            string[] a = response.Split(':');
            string a2 = a[1].Substring(1);
            string[] a3 = a2.Split('<');
            string publicIP = a3[0];
            return publicIP;
        }
    }
}
