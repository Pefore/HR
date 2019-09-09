﻿using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFBLL
{
    public interface IFBLLRight
    {
        List<rightModel> RightSelect();
        int Add(rightModel rm);
        int Del(rightModel rm);
        int Update(rightModel rm);
        Dictionary<string, object> FenYe(int currentPage);
        List<rightModel> RightSelectBy(rightModel rm);
        DataTable selectQX(string rid, string pid);
        int DeletePer(string rid);
        int AddPer(string sql);

        rightModel RightSelectBys(int id);
    }
}
