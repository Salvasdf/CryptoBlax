using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBlax2
{
    class Crypto
    {
        int id_file;
        string file_name;
        DateTime date_encrypted;
        int q_wrongpass;
        int q_success_decrypt;
        string self_destruct_date;
        string ip_access_history;
        string private_pass;
        string file_md5;
        int iterations;

        public Crypto(int id_file, string file_name, DateTime date_encrypted, int q_wrongpass, int q_success_decrypt, string self_destruct_date, string ip_access_history, string private_pass, string file_md5, int iterations)
        {
            this.id_file = id_file;
            this.file_name = file_name;
            this.date_encrypted = date_encrypted;
            this.q_wrongpass = q_wrongpass;
            this.q_success_decrypt = q_success_decrypt;
            this.self_destruct_date = self_destruct_date;
            this.ip_access_history = ip_access_history;
            this.private_pass = private_pass;
            this.file_md5 = file_md5;
            this.iterations = iterations;
        }
    }
}
