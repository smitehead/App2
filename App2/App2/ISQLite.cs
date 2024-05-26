using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2
{
    public interface ISQLite
    {
        SQLiteAsyncConnection GetConnection();
    }
}
