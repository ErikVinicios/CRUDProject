using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDProject
{
    public static class Validations
    {
        public static bool EmailIsValid(string email)
        {
			try
			{
                var enderecoEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                return enderecoEmail.IsMatch(email);
			}
			catch
			{
                return false;
			}
        }
        public static bool NumberIsValid(string number)
        {
			try
			{
				var Number = new Regex("^\\([1-9]{2}\\) (?:[2-8]|9[1-9])[0-9]{3}\\-[0-9]{4}$");
				return Number.IsMatch(number);
			}
			catch (Exception)
			{
				return false;
			}
        }
    }
}
