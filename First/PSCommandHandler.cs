using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Management.Automation;

namespace First
{
    public class PSCommandHandler
    {
        private readonly PowerShell _ps;

        public PSCommandHandler()
        {
            _ps = PowerShell.Create();
            //_ps.AddCommand("Out-String");

        }

        
        
        public IEnumerable<string> GetAliases()
        {
            
            _ps.AddCommand("Get-Alias");
            var result = _ps.Invoke();

            return result.Select(x => x.ToString());
        }
    }
}
