using System;

namespace org.csharp
{
    public class CustomUsing<T> where T:IDisposable
    {
        public static Action<T, Action<T>> mUsing = (con, acton) =>
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
