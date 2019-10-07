using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackATL_EEVM.Views
{

    public class MainMasterDetailMasterMenuItem
    {
        public MainMasterDetailMasterMenuItem()
        {
            TargetType = typeof(MainMasterDetailMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}