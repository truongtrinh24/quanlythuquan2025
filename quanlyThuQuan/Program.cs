﻿using System;
using System.Windows.Forms;
using OfficeOpenXml; // ⬅️ Dòng này cực kỳ quan trọng
using quanlyThuQuan.GUI;

namespace quanlyThuQuan
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize(); // Phải gọi trước

            Login loginForm = new Login();
            loginForm.ShowDialog();

            if (Login.isAuthenticated)
            {
                Application.Run(new MainForm());
            }
        }
    }
}
