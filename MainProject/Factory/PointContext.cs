using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Interfaces;

namespace MainProject.Factory
{
    public class PointContext
    {
        private SplitTableInterface _splitTableInterface;

        public PointContext(SplitTableInterface splitTableInterface)
        {
            this._splitTableInterface = splitTableInterface;
        }

        public void excuate()
        {
             _splitTableInterface.SplitTable();
        }
    }
}
