# Custom-Using
Create and use custom using block to free unmanaged resources

We generally use using block to free ourselves from closing or disposing the unmanaged resources.
This class shows a simple way of achieving the functionality analogous to using block

# How to Use:

            using org.csharp
            SqlConnection con = new SqlConnection();
            CustomUsing<SqlConnection>.mUsing(con, i =>
            {
                i.Open();
            });
            
NOTE:Remember to only use objects inherited from IDisposable
