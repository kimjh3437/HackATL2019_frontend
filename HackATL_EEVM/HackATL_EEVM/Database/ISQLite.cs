using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackATL_EEVM.Database
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
