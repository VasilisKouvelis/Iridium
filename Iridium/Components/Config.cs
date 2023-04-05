using Iridium.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iridium.Components {
    public class Config {
        private static readonly int maxSkills = 4;
        //private static readonly object padlock = new object();
        private IniSettings Settings;

        public IniSettings GetSettings() {
            return this.Settings;
        }

        public String IniFilePath { get; set; }

        public String[] Intervals { get; set; } = new String[maxSkills + 3 + 1];    //4 skills ,3 mouse , 1 force
        public String[] Keys { get; set; } = new String[maxSkills];
        public Boolean[] Enabled { get; set; } = new Boolean[maxSkills];
        public Boolean[] MouseEnabled { get; set; } = new Boolean[3];
        public Boolean ForceMove = false;

        public Config(String path) {
            this.IniFilePath = path;
            if (!File.Exists(path)) {
                CreateNewFile(path);
            }
            LoadAbilities();
        }

        //Create new Ini File
        public Boolean CreateNewFile(String fileName) {
            try {
                //create new default profile
                File.Create(fileName);
                using (TextWriter tw = new StreamWriter(fileName)) {
                    tw.WriteLine("#File Created :" + DateTime.Now.ToString());
                }
                String[] keys = { "Q", "W", "E", "R" };
                String section = null;
                this.Settings = new IniSettings(fileName);
                //read skills Settings
                for (int x = 0; x < maxSkills; x++) {
                    section = new StringBuilder().Append("Skill_").Append(x + 1).ToString();
                    Settings.Write("interval", "500", section);
                    Settings.Write("key", keys[x], section);
                    Settings.Write("enabled", "1", section);
                }
                //read mouse Settings
                for (int x = 0; x < 3; x++) {
                    section = new StringBuilder().Append("Mouse_").Append(x + 1).ToString();
                    Settings.Write("interval", "500", section);
                    Settings.Write("enabled", "0", section);
                }
                Settings.Write("top_most", "1", "Options");
                Settings.Write("opacity", "100", "Options");
                Settings.Write("mini_mode", "0", "Options");
                Settings.Write("interval", "500", "Force_Move");
                Settings.Write("enabled", "0", "Force_Move");
            }
            catch (Exception SexInTheCity) {
                MessageBox.Show("You cannot load from file: " + fileName, @"Load Profile Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.IniFilePath = "profile_default.ini";
                MessageBox.Show("KRATA MOY AYTO TO ERROR AN VGEI:\n\nTRAVA KAI SS\n\n" + SexInTheCity.ToString());
                return false;
            }

            return true;
        }




        public void SaveAbilities(TextBox[] texts, Boolean[] enabled, InputManager[] input) {
            this.Settings = new IniSettings(this.IniFilePath);
            string section;
            for (int x = 0; x < maxSkills; x++) {
                section = new StringBuilder().Append("Skill_").Append(x + 1).ToString();
                if (!String.IsNullOrEmpty(texts[x].Text)) {
                    Settings.Write("interval", (int.Parse(texts[x].Text) > 0 ? texts[x].Text : "500"), section);
                    Settings.Write("key", input[x].GetKeyName(), section);
                    Settings.Write("enabled", (enabled[x] ? "1" : "0"), section);
                }


            }
            for (int x = 0; x < 3; x++) {
                section = new StringBuilder().Append("Mouse_").Append(x + 1).ToString();
                Settings.Write("interval", texts[x + 4].Text, section);
                Settings.Write("enabled", (enabled[x + 4] ? "1" : "0"), section);
            }
        }

        public void LoadAbilities() {
            LoadAbilities(this.IniFilePath);
        }

        public void LoadAbilities(String path) {
            this.IniFilePath = path;
            this.Settings = new IniSettings(path);
            string section;
            for (int x = 0; x < maxSkills; x++) {
                section = new StringBuilder().Append("Skill_").Append(x + 1).ToString();
                //ola gia to prwto skills prwta.
                Intervals[x] = Settings.ReadString("interval", section);
                Keys[x] = Settings.ReadString("key", section);
                Enabled[x] = Settings.ReadBoolean("enabled", section);
            }
            for (int x = 0; x < 3; x++) {
                section = new StringBuilder().Append("Mouse_").Append(x + 1).ToString();
                Intervals[x + 4] = Settings.ReadString("interval", section);
                MouseEnabled[x] = Settings.ReadBoolean("enabled", section);
            }
            ForceMove = Settings.ReadBoolean("enabled", "Force_Move");
            Intervals[7] = Settings.ReadString("interval", "Force_Move");
        }
    }
}
