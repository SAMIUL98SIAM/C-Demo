using System;
using System.Collections.Generic;
using System.Text;

namespace SmartFishFarm2.io
{
    interface ISensorIO
    {
        void showError(string error);
        void showMssg(string msg);
    }
}
