using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HospitalManageSys
{
    class SqlCmd
    {
        public static bool iflogin = false;
        public static string admin_id;
        public static string admin_name;
        public static string admin_sex;
        public static string admin_job;
        public static byte capab=0x00;
        public static string admin_depart;
        public static MemoryStream memStream = null;

        public const string strcon = "Server=localhost;Database=HospitalManageSys;Uid=root;Pwd=zixue788634;";
    }
}
