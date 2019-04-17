using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Model.Entities
{
    class Circle : AbstractShape
    {
        public double Raio { get; set; }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }

        public override string ToString()
        {
            return "Circulo cor = "
                + Color
                + ", Raio = "
                + Raio.ToString("F2", CultureInfo.InvariantCulture)
                +", Area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
