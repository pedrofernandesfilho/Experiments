﻿using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Exp.Core.Common.Contracts
{
    public interface IADOConnection
    {
        DataSet ExecuteSqlDataSet(string sql, IList<DbParameter> parammeters);
        DbParameter CreateParammter(string parameterName, object value);
    }
}