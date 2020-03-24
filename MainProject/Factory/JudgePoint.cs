using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Interfaces;

namespace MainProject.Factory
{
    public class JudgePoint
    {
        public void judge(SplitTableInterface splitTableInterface)
        {
            PointContext pointContext = new PointContext(splitTableInterface);
            pointContext.excuate();
        }
    }
}
