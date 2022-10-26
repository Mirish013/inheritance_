using System;
using System.Security.Permissions;
using System.Text;

namespace Inheritance
{
    public class ikiboyut
    {
        public double A { get; set; }
        public double H { get; set; }

        public void Goster()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Oturacaq : " + A);
            builder.Append(Environment.NewLine);
            builder.Append("Hundurluk : " + H);
            Console.WriteLine(builder.ToString());
        }
    }
}