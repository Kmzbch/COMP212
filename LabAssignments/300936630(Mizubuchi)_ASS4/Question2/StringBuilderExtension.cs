using System.Linq;
using System.Text;

namespace Question2
{
    public static class StringBuilderExtension
    {
        // define extension method
        public static int Count(this StringBuilder sb) => sb.ToString().Split(' ').Count();
    }
}
