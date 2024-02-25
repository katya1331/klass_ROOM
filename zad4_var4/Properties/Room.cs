using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace zad4_var4.Properties
{
    internal class Room
    {
        public double x {  get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public int CountWindow;
        public double xWindow;
        public double yWindow;
        public double xdoor;
        public double ydoor;
        public string s1;
        public string s2;
        public string s3;
        public string s4;
        public double S (double x, double y)
        {
            return x * y;
        }
        public double V (double x, double y, double z)
        {
            return x * y * z;
        }
        public double P (double x, double y)
        {
            return (x + y)*2;
        }
        public string Oboi(double x, double y, double z, int CountWindow, double xWindow,double yWindow,double xdoor,double ydoor)
        {
            double Sremonta = (z * P(x, y)) - (CountWindow * P(xWindow, yWindow)) - P(xdoor, ydoor);
            double nado1 = Math.Ceiling(Sremonta / 15);
            double nado2 = Math.Ceiling(Sremonta / 10);
            if (nado2<1)
            {
                s4 = $"Вам надо хватит и 1 рулона в 10м";
            }else
            s4 = $"Вам надо рулонов обоев по 15м - {nado1}  \n Вам надо рулонов обоев по 10м -{nado2}";
            return s4;
        }
        public string Info(double x, double y)
        {
            double people = Math.Floor((x * y) / 10);
            if(people > 0)
            {
                s3 = $"Вы можете поселить - {Math.Floor((x * y) / 10)} человек(а) в комнату";
            }else
            s3 = $"Комната будет тесной даже для одного человека";
            return s3;
        }
    }
}
