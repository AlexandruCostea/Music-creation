﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using Microsoft.Data.SqlClient;
using Music.MusicDomain;

namespace MauiApp1.Repository
{
    internal class MusigTagRepository : IMusicTagRepository
    {
        //private SqlConnection conn;
        private List<MusicTag> tags;

        private string getConnectionString()
        {
            return "Data Source=DESKTOP-A6LKOMJ\\SQLEXPRESS;" +
                "Initial Catalog=CargoShipGlobal;Integrated Security=true;";
        }

        public MusigTagRepository() 
        {
            //conn = new SqlConnection(getConnectionString());
            tags = new List<MusicTag>();
        }

        public void add(MusicTag elem)
        {
            tags.Add(elem);
        }

        public MusicTag? search(int id)
        {
            return (from tag in tags
                   where tag.getId() == id
                   select tag).FirstOrDefault();
        }

        public MusicTag[] getAll()
        {
            return (from tag in tags
                   select tag).ToArray();
        }
    }
}
