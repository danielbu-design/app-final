﻿using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;

using SQLite;
using Xamarin.Forms;
using System.IO;
using SQLiteAgenda.Datos;
using SQLiteAgenda.iOS;

[assembly: Dependency(typeof(SQLiteDB))]
namespace SQLiteAgenda.iOS
{
    public class SQLiteDB : ISQLiteDB
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var ruta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            // Se crea la base de datos
            var path = Path.Combine(ruta, "AgendaSQLite.db3");
            return new SQLiteAsyncConnection(path);
        }
    }
}