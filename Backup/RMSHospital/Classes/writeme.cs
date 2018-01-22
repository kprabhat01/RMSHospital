using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace WindowsFormsApplication1.Classes
{
    class writeme
    {
        public static void errorname(Exception ex)
        {
            try
            {
                string filePath = System.IO.Path.GetTempPath()+DateTime.Now.ToString("ddMMMyyyy")+"'.txt";
                //string filePath = HttpContext.Current.Server.MapPath("~/logs/logs_" + DateTime.Now.ToString("ddMMMyyyy") + ".txt");
                //FileStream fs = null;
                FileStream fs = null;

                if (!File.Exists(filePath))
                {

                    using (fs = File.Create(filePath))
                    {

                    }

                }
                if (File.Exists(filePath))
                {
                    StreamWriter writer = new StreamWriter(filePath, true);
                    //writer.WriteLine(HttpContext.Current.Request.Url.ToString());
                    writer.WriteLine(DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss") + " " + ex.Message + "\n");
                    writer.WriteLine(ex.StackTrace);
                    writer.WriteLine("\n");
                    writer.Flush();
                    writer.Close();

                }
            }
            catch (Exception e)
            {
                messagemode.messageget(false, ex.Message);
            }
            finally
            {
                detail.con.Close();
            }
        }

    }
}
