using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Iridium.Components {

    public class IniSettings {
        private readonly string Path;
        private readonly string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public IniSettings(string? IniPath = null) {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName.ToString();
        }

        public Boolean ReadBoolean(string Key, string? Section = null) {
            if (Key is null) {
                throw new ArgumentNullException(nameof(Key));
            }

            var RetVal = new StringBuilder(255);
            _ = GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString().ToLower() switch {
                "true" or "t" or "1" => true,
                "false" or "f" or "0" => false,
                _ => false,//throw new InvalidCastException("You can't cast that value to a Boolean!");
            };
        }

        public string ReadString(string Key, string? Section = null) {
            if (Key is null) {
                throw new ArgumentNullException(nameof(Key));
            }

            var RetVal = new StringBuilder(255);
            _ = GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string? Section = null) {
            if (Key is null) {
                throw new ArgumentNullException(nameof(Key));
            }

            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        public void DeleteKey(string Key, string? Section = null) {
            if (Key is null) {
                throw new ArgumentNullException(nameof(Key));
            }

            Write(Key, null, Section ?? EXE);
        }

        public void DeleteSection(string? Section = null) {
            Write(null, null, Section ?? EXE);
        }

        public Boolean KeyExists(string Key, string? Section = null) {
            if (Key is null) {
                throw new ArgumentNullException(nameof(Key));
            }

            return ReadString(Key, Section).Length > 0;
        }
    }
}