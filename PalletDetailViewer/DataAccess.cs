using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalletDetailViewer.Models;

namespace PalletDetailViewer
{
    class DataAccess
    {
        public static bool GetData(string sMaterialCode, out MaterialCode myMaterialCode, out string sMessage)
        {
            myMaterialCode = new MaterialCode();
            sMessage = "";

            myMaterialCode.sPlant = "SASW";
            myMaterialCode.sMaterialCode = sMaterialCode;
            myMaterialCode.dTotalCost = 1000.0M;

            return true;
        }
    }
}
