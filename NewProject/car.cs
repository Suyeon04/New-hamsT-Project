using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newProject
{
    class car
    {
        /***
         * carNumber : 자동차 번호
         ***/
        int carNumber;
        DataTime inTime;
        DataTime outTime;

        //<summary>
        //자동차가 들어온 시간 설정
        //</summary>

        internal void SetInTime()
        {
            this.inTime = DataTime.Now;
        }

        internal void SetOutTime()
        {
            this.outTime = DataTime.Now;
        }
    }
    
}

