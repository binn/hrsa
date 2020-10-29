using System;
using System.IO;

namespace HRSA
{
    public class Global
    {
        public static string MasterTIN { get; set; } = "None";
        
        public static void SetMasterTIN(string value)
        {
            string tinPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "HRSA-ECW-Data\\", "tin.txt");

            if (!File.Exists(tinPath))
            {
                if (!Directory.Exists(Path.GetDirectoryName(tinPath)))
                    Directory.CreateDirectory(Path.GetDirectoryName(tinPath));

                File.Create(tinPath).Close();
            }

            File.WriteAllText(tinPath, MasterTIN = value);
        }

        public static string ReadMasterTIN()
        {
            string tinPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "HRSA-ECW-Data\\", "tin.txt");
            MasterTIN = File.Exists(tinPath) ? File.ReadAllText(tinPath) : "None";

            if (string.IsNullOrWhiteSpace(MasterTIN))
                SetMasterTIN("None");

            return MasterTIN;
        }
    }
}
