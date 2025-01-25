using System;

namespace CarRentalSystem.Models
{
    internal class DipalyNameAttribute : Attribute
    {
        private string v;

        public DipalyNameAttribute(string v)
        {
            this.v = v;
        }
    }
}