using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class DBAccess
    {
        private IErrorLogger _logger;
        public DBAccess(IErrorLogger el)
        {
            _logger = el;
            
        }

        public void SaveUserData(string name, int age)
        {
            try
            {
                //...saving the data
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message);
            }
        }
    }
}
