﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOPSample02
{
    public interface IFileAccess
    {
        void Create();
        void Delete();
        void Write();
        void Read();
    }

    public class FileAccess : IFileAccess
    {
        private string _file;
        public FileAccess(string filename)
        { _file = filename; }

        public void Create()
        {
            Console.WriteLine(string.Format("Create a file : {0}", _file));
            LogHelper.Log();
        }

        public void Delete()
        {
            Console.WriteLine(string.Format("Delete a file :{0}", _file));
            LogHelper.Log();
        }

        public void Read()
        {
            Console.WriteLine(string.Format("Read from a file :{0}", _file));
            LogHelper.Log();
        }

        public void Write()
        {
            Console.WriteLine(string.Format("Write to a file :{0}", _file));
            LogHelper.Log();
        }
    }

    public class LogHelper
    {
        public static void Log()
        {
            Console.WriteLine("Log something......");
        }
    }
}
