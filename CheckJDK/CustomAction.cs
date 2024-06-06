using System.IO;
using WixToolset.Dtf.WindowsInstaller;

namespace CheckJDK
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult CheckJDK21(Session session)
        {
            string eclipseAdoptiumDir = @"C:\Program Files\Eclipse Adoptium";

            if (Directory.Exists(eclipseAdoptiumDir))
            {
                string[] jdk21Folders = Directory.GetDirectories(eclipseAdoptiumDir, "jdk-21*");

                if (jdk21Folders.Length > 0)
                {
                    session["JDK21_INSTALLED"] = "1";
                    return ActionResult.Success;
                }
            }

            session["JDK21_INSTALLED"] = "0";
            return ActionResult.Success;
        }
    }
}
