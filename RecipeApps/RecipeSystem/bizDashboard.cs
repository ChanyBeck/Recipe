using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizDashboard : bizObject<bizDashboard>
    {
        private string _dashboardType = "";
        private int _dashboardNum = 0;

        public string DashboardType
        {
            get { return _dashboardType; }
            set
            {
                if (_dashboardType != value)
                {
                    _dashboardType = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int DashboardNum
        {
            get { return _dashboardNum; }
            set
            {
                if (_dashboardNum != value)
                {
                    _dashboardNum = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
