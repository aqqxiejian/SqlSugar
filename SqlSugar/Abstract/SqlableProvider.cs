﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlSugar
{
    public partial class SqlableProvider : ISugarSqlable
    {
        public SqlSugarClient Context { get; set; }
    }
}