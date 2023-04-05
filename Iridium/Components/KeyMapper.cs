namespace Iridium.Components {

    public class KeyMapper {

        public static String GetNumeric(Keys key) {
            string ret = GetKey(key).ToUpper();
            if (ret.Contains('D') && !ret.Equals("D")) ret = ret.Replace("D", "");
            return ret;
        }

        public static String GetKeyString(Keys key) {
            return GetKey(key).ToUpper();
        }

        public static String GetKey(Keys key) {
            switch (key) {
                //Numbers
                case Keys.D0: return "0";
                case Keys.D1: return "1";
                case Keys.D2: return "2";
                case Keys.D3: return "3";
                case Keys.D4: return "4";
                case Keys.D5: return "5";
                case Keys.D6: return "6";
                case Keys.D7: return "7";
                case Keys.D8: return "8";
                case Keys.D9: return "9";

                //Letters
                case Keys.A: return "a";
                case Keys.B: return "b";
                case Keys.C: return "c";
                case Keys.D: return "d";
                case Keys.E: return "e";
                case Keys.F: return "f";
                case Keys.G: return "g";
                case Keys.H: return "h";
                case Keys.I: return "i";
                case Keys.J: return "j";
                case Keys.K: return "k";
                case Keys.L: return "l";
                case Keys.M: return "m";
                case Keys.N: return "n";
                case Keys.O: return "o";
                case Keys.P: return "p";
                case Keys.Q: return "q";
                case Keys.R: return "r";
                case Keys.S: return "s";
                case Keys.T: return "t";
                case Keys.U: return "u";
                case Keys.V: return "v";
                case Keys.W: return "w";
                case Keys.X: return "x";
                case Keys.Y: return "y";
                case Keys.Z: return "z";
                default: return "Error";
            }
        }

        public static Keys SelectKeyFromString(String key) {
            switch (key) {
                case "a":
                case "A":
                    return Keys.A;

                case "b":
                case "B":
                    return Keys.B;

                case "c":
                case "C":
                    return Keys.C;

                case "d":
                case "D":
                    return Keys.D;

                case "e":
                case "E":
                    return Keys.E;

                case "f":
                case "F":
                    return Keys.F;

                case "g":
                case "G":
                    return Keys.G;

                case "h":
                case "H":
                    return Keys.H;

                case "i":
                case "I":
                    return Keys.I;

                case "j":
                case "J":
                    return Keys.J;

                case "k":
                case "K":
                    return Keys.K;

                case "l":
                case "L":
                    return Keys.L;

                case "m":
                case "M":
                    return Keys.M;

                case "n":
                case "N":
                    return Keys.N;

                case "o":
                case "O":
                    return Keys.O;

                case "p":
                case "P":
                    return Keys.P;

                case "q":
                case "Q":
                    return Keys.Q;

                case "r":
                case "R":
                    return Keys.R;

                case "s":
                case "S":
                    return Keys.S;

                case "t":
                case "T":
                    return Keys.T;

                case "u":
                case "U":
                    return Keys.U;

                case "v":
                case "V":
                    return Keys.V;

                case "w":
                case "W":
                    return Keys.W;

                case "x":
                case "X":
                    return Keys.X;

                case "y":
                case "Y":
                    return Keys.Y;

                case "z":
                case "Z":
                    return Keys.Z;

                case "1":
                    return Keys.D1;

                case "2":
                    return Keys.D2;

                case "3":
                    return Keys.D3;

                case "4":
                    return Keys.D4;

                case "5":
                    return Keys.D5;

                case "6":
                    return Keys.D6;

                case "7":
                    return Keys.D7;

                case "8":
                    return Keys.D8;

                case "9":
                    return Keys.D9;

                case "0":
                    return Keys.D0;
                default:
                    break;
            }
            return Keys.Escape;
        }

        public static Keys SelectKey(char key) {
            switch (key) {
                //Numbers
                case (char)Keys.D0: return Keys.D0;
                case (char)Keys.D1: return Keys.D1;
                case (char)Keys.D2: return Keys.D2;
                case (char)Keys.D3: return Keys.D3;
                case (char)Keys.D4: return Keys.D4;
                case (char)Keys.D5: return Keys.D5;
                case (char)Keys.D6: return Keys.D6;
                case (char)Keys.D7: return Keys.D7;
                case (char)Keys.D8: return Keys.D8;
                case (char)Keys.D9: return Keys.D9;

                //Letters
                case (char)Keys.A:
                case (char)'a': return Keys.A;

                case (char)Keys.B:
                case (char)'b': return Keys.B;

                case (char)Keys.C:
                case (char)'c':
                    return Keys.C;

                case (char)Keys.D:
                case (char)'d':
                    return Keys.D;

                case (char)Keys.E:
                case (char)'e':
                    return Keys.E;

                case (char)Keys.F:
                case (char)'f':
                    return Keys.F;

                case (char)Keys.G:
                case (char)'g':
                    return Keys.G;

                case (char)Keys.H:
                case (char)'h':
                    return Keys.H;

                case (char)Keys.I:
                case (char)'i':
                    return Keys.I;

                case (char)Keys.J:
                case (char)'j':
                    return Keys.J;

                case (char)Keys.K:
                case (char)'k':
                    return Keys.K;

                case (char)Keys.L:
                case (char)'l':
                    return Keys.L;

                case (char)Keys.M:
                case (char)'m':
                    return Keys.M;

                case (char)Keys.N:
                case (char)'n':
                    return Keys.N;

                case (char)Keys.O:
                case (char)'o':
                    return Keys.O;

                case (char)Keys.P:
                case (char)'p':
                    return Keys.P;

                case (char)Keys.Q:
                case (char)'q':
                    return Keys.Q;

                case (char)Keys.R:
                case (char)'r':
                    return Keys.R;

                case (char)Keys.S:
                case (char)'s':
                    return Keys.S;

                case (char)Keys.T:
                case (char)'t':
                    return Keys.T;

                case (char)Keys.U:
                case (char)'u':
                    return Keys.U;

                case (char)Keys.V:
                case (char)'v':
                    return Keys.V;

                case (char)Keys.W:
                case (char)'w':
                    return Keys.W;

                case (char)Keys.X:
                case (char)'x':
                    return Keys.X;

                case (char)Keys.Y:
                case (char)'y':
                    return Keys.Y;

                case (char)Keys.Z:
                case (char)'z':
                    return Keys.Z;
                default:
                    break;
            }
            return Keys.Escape;
        }
    }
}