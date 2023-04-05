using Iridium.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Iridium.Managers {
    public class InputManager {
        private Keys CurrentKey;
        private bool Replace { get; set; }
        public Color EnabledColor { get; set; }
        public Color DisabledColor { get; set; }

        public InputManager() {
            this.CurrentKey = Keys.Escape;
            this.Replace = false;
            this.EnabledColor = Color.Orange;
            this.DisabledColor = Color.Red;
        }

        public InputManager(Keys cur) {
            this.CurrentKey = cur;
            this.Replace = false;
            this.EnabledColor = Color.Orange;
            this.DisabledColor = Color.Red;
        }

        public InputManager(Keys cur, Color enabled, Color disabled) {
            this.CurrentKey = cur;
            this.Replace = false;
            this.EnabledColor = enabled;
            this.DisabledColor = disabled;
        }

        public Keys GetKey() {
            return this.CurrentKey;
        }

        public string GetKeyName() {
            return KeyMapper.GetNumeric(this.CurrentKey);
        }

        public void SetKey(Keys newKey) {
            this.CurrentKey = newKey;
        }

        public Color Toggle() {
            Replace = !Replace;
            return (Replace ? this.EnabledColor : this.DisabledColor);
        }

        public bool CanReplace() {
            return this.Replace;
        }
    }
}
