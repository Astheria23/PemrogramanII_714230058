﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace P11_714230058.controller
{
    class CekLogin
    {
        koneksi koneksi = new koneksi();
        public bool cek_login(string username, string password)
        {
            try
            {
                koneksi.OpenConnection();
                MySqlDataReader reader = koneksi.reader("SELECT * FROM t_user WHERE username = '" + username + "' AND password = '" + password + "'");
                if (reader.Read())
                {
                    koneksi.CloseConnection();
                    return true;
                }
                else
                {
                    koneksi.CloseConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Login", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
