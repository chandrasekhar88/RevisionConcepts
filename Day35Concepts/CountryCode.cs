using System;

namespace Day35Concepts
{
    public class CountryCode
    {
        public string code { get; }

        public CountryCode(string countryCode)
        {
            code = countryCode;
        }

        public override bool Equals(object anonymous)
        {
            if (anonymous == null)
            {
                return false;
            }

            if (!(anonymous is CountryCode))
            {
                return false;
            }

            return StringComparer.OrdinalIgnoreCase.Equals(this.code, ((CountryCode)anonymous).code);
        }

        public override int GetHashCode()
        {
            return StringComparer.OrdinalIgnoreCase.GetHashCode(this.code);
        }
    }
}
