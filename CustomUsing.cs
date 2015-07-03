using System;

namespace org.csharp
{
    class CustomUsing
    {
        Action<IDisposable, Action<IDisposable>> mUsing = (con, acton) =>
        {
            try
            {
                acton(con);
            }
            catch
            {
                con.Dispose();
            }
            finally
            {
                con.Dispose();
            }
        };
    }
}
