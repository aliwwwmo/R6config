using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;


namespace R6Config
{
    class change_server
    {
        
        public void ReplaceDataCenterHint(string directoryPath, string newValue)
        {
            try
            {
                // Get all directories and subdirectories in the specified path
                string[] allDirectories = Directory.GetDirectories(directoryPath, "*", SearchOption.AllDirectories);

                // Iterate through each directory
                foreach (string dir in allDirectories)
                {
                    try
                    {
                        // Find all GameSettings.ini files in the current directory
                        string[] gameSettingsFiles = Directory.GetFiles(dir, "GameSettings.ini", SearchOption.TopDirectoryOnly);

                        // Iterate through each GameSettings.ini file
                        foreach (string filePath in gameSettingsFiles)
                        {
                            // Read the content of the file
                            string fileContent = File.ReadAllText(filePath);

                            // Define the pattern to match DataCenterHint= and its value
                            string pattern = @"DataCenterHint=(.*)";

                            // Replace matches with the new value
                            string newContent = Regex.Replace(fileContent, pattern, $"DataCenterHint={newValue}");

                            // Write the modified content back to the file
                            File.WriteAllText(filePath, newContent);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while processing directory {dir}: {ex.Message}");
                    }
                }

                MessageBox.Show("All GameSettings.ini files modified successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        public void Replacesens(string directoryPath, string newValue)
        {
            try
            {
                // Get all directories and subdirectories in the specified path
                string[] allDirectories = Directory.GetDirectories(directoryPath, "*", SearchOption.AllDirectories);

                // Iterate through each directory
                foreach (string dir in allDirectories)
                {
                    try
                    {
                        // Find all GameSettings.ini files in the current directory
                        string[] gameSettingsFiles = Directory.GetFiles(dir, "GameSettings.ini", SearchOption.TopDirectoryOnly);

                        // Iterate through each GameSettings.ini file
                        foreach (string filePath in gameSettingsFiles)
                        {
                            // Read the content of the file
                            string fileContent = File.ReadAllText(filePath);

                            // Define the pattern to match DataCenterHint= and its value
                            string pattern = @"MouseSensitivityMultiplierUnit=(.*)";

                            // Replace matches with the new value
                            string newContent = Regex.Replace(fileContent, pattern, $"MouseSensitivityMultiplierUnit={newValue}");

                            // Write the modified content back to the file
                            File.WriteAllText(filePath, newContent);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while processing directory {dir}: {ex.Message}");
                    }
                }

                MessageBox.Show("All GameSettings.ini files modified successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
