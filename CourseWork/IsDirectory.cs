using System;
using System.Collections.Generic;
using System.IO;
using System.Configuration;

namespace CourseWork
{
    class IsDirectory: ConsWindows
    {
        private string _name;
        private string[] _array;
        private string[] _files;
        private Configuration _configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        private KeyValueConfigurationCollection _settings; 

        public List<string> FolderList = new List<string>();

        public string Name 
        {
            get {
                if (_name == null)
                {
                    _settings = _configFile.AppSettings.Settings;
                    _name = _settings["Direction"].Value;
                }
                return _name;
            }
            set {
                if (_name == null)
                {
                    _settings = _configFile.AppSettings.Settings;
                    _name = _settings["Direction"].Value;
                    value = _name;
                }
                if (Directory.Exists(value))
                {
                    _name = value;
                    _array = Directory.GetDirectories(_name);
                    _files = Directory.GetFiles(_name);
                    Console.SetCursorPosition(5,0);
                    Console.WriteLine(_name);
                    this.SaveConfig();
                    this.FolderList.Clear();
                    this.ReadAndWriteFolder(ConsoleColor.White);
                    this.ReadAndWriteFile(ConsoleColor.Black);
                }
            }
        }
        public string[] Array
        {
            get
            {
                return _array;
            }
        }
        public IsDirectory(int x, int y, ConsoleColor foreСolor) : base(x, y, foreСolor)
        {
            X = x;
            Y = y;
            Console.SetCursorPosition(X, Y);
        }
        public void ReadAndWriteFolder(ConsoleColor color)
        {
            ForeColor = color;
            if (_array != null)
            {
                foreach (string s in _array)
                {
                    this.Position(3, Y);
                    Console.WriteLine(s.Replace(_name, ""));
                    FolderList.Add(s.Replace(_name, ""));
                    Y++;
                }
            }
        }
        public void ReadAndWriteFile(ConsoleColor color)
        {
            ForeColor = color;
            if (_files != null)
            {
                foreach (string s in _files)
                {
                    this.Position(3, Y);
                    Console.WriteLine(s.Replace(_name, ""));
                    FolderList.Add(s.Replace(_name, ""));
                    Y++;
                }
            }
        }
        private void SaveConfig()
        {
            _settings = _configFile.AppSettings.Settings;
            //очищение конфигурации
            _settings.Remove("Direction");
            //сохранение новых конфигураций
            _settings.Add("Direction", this._name);
            _configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(_configFile.AppSettings.SectionInformation.Name);
        }

        //метод вывода информации о каталоге
        public void OutInfoDirectory(DirectoryInfo dirName)
        {
            this.Position(63, 2);
            this.BackColor = ConsoleColor.DarkBlue;
            Console.Write($"Время создания {dirName.CreationTime}");
        }
        public void DelFiles()
        {
            FileInfo fileInf = new FileInfo(Name.Substring("rm".Length, Name.Length - 2));
            if (fileInf.Exists)
            {
                fileInf.Delete();
                ScreenВrawing();
            }
            else
            {
                try
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(Name.Substring("rm".Length, Name.Length - 2));
                    dirInfo.Delete(true);
                    ScreenВrawing();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void Copy()
        {
            FileInfo fileInf = new FileInfo(Name.Substring("cp".Length, Name.IndexOf(' ') - 1));
            if (fileInf.Exists)
            {
                string s = Name.Substring(Name.IndexOf(' ') - 1, Name.Length);
                fileInf.CopyTo(Name.Substring(Name.IndexOf(' '), Name.Length - 2), true);
            }
        }

    }
}
