using System;
using System.IO;
using System.Windows.Forms;

namespace txtChat
{
    class Program
    {
        public static string filename = @"chat.txt";
        public static string filedir = Path.GetDirectoryName(filename);
        public static string filepath = Path.GetFullPath(filename);
        public static string bindir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6);
        public static ChatWindow Form;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form = new ChatWindow();
            CreateFileWatcher();
            var content = File.ReadAllText(filepath);
            Form.ReplaceChat(content);
            Application.Run(Form);
        }

        public static void SendMessage(string msg)
        {
            msg = $"[{DateTime.Now.ToString("HH:mm:ss")}] {Environment.MachineName}: {msg}";
            //MessageBox.Show(msg);
            //File.AppendAllText(Path.Combine(bindir, filename), msg + Environment.NewLine);
            File.AppendAllLines(filename, new string[] { msg });
        }

        public static void CreateFileWatcher()
        {
            FileSystemWatcher watcher = new FileSystemWatcher
            {
                Path = bindir,
                NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                | NotifyFilters.FileName | NotifyFilters.DirectoryName,
                Filter = filename
            };
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            /*watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);*/
            watcher.EnableRaisingEvents = true;
        }

        public static void OnChanged(object source, FileSystemEventArgs e)
        {
            var content = File.ReadAllText(e.FullPath);
            Form.ReplaceChat(content);
            System.Media.SystemSounds.Beep.Play();
        }

        /*public static void OnRenamed(object source, RenamedEventArgs e)
        {
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
        }*/
    }
}
