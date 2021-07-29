using EmployeeManagementWebUI.ViewModel.SCRN0001;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementWebUI.Helper
{
    public class EV0001Helper : IEV0001Helper
    {
        public SCRN0001ViewModelDTO Init()
        {
            return new SCRN0001ViewModelDTO();
        }
    }
}
