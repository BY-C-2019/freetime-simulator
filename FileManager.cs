using System;
using System.IO;

namespace freetime_simulator
{
    class FileManager
    {
        static public bool DeleteFile(string fileName, string dirPath = "")
        {
            // If no directory was entereted, set path to current directory
            if (dirPath == "") {
                dirPath = Directory.GetCurrentDirectory();
            }

            // Fullpath of file
            string fullPath = Path.Combine(dirPath, fileName);
            
            // Delete file if it exists
            if (File.Exists(fullPath)) {
                File.Delete(fullPath);
                return true;
            }

            return false;
        }
        static public void Write(string textToWrite, string fileName, string dirPath = "")
        {
            // If no directory was entereted, set path to current directory
            if (dirPath == "") {
                dirPath = Directory.GetCurrentDirectory();
            }

            // Append text to specified file (creates the file if it doesnt exist)
            File.AppendAllText(Path.Combine(dirPath, fileName), textToWrite);
        }
    }
}