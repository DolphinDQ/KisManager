using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KisManager.Config
{
    public class KisLoginDebug : IKisLogin
    {
        /*
IsDemo=>True
IsIndustry=>True
PropsString=>ConnectString={Persist Security Info=True;Provider=SQLOLEDB.1;User ID=sa;Password=1;Data Source=AA-34E1F2ABE335;Initial Catalog=AIS20151222162701};UserName=administrator;UserID=16394;DBMS Name=Microsoft SQL Server;DBMS Version=2000/2005;SubID=super;AcctType=gy;Setuptype=Industry;Language=chs;IP=192.168.248.128;K3Version=KUE;MachineName=AA-34E1F2ABE335;UUID=2A070315-B37B-4CAD-B559-7020F95AB1E5
ServerMgr=>System.__ComObject
UserName=>administrator
AcctName=>银农科技（新）20160217
        */

        public string AcctName => "银农科技（新）20160217";

        public bool IsDemo => true;

        public bool IsIndustry => true;

        public string PropsString => "ConnectString={Persist Security Info=True;Provider=SQLOLEDB.1;" +
                                    "User ID=sa;Password=1;Data Source=AA-34E1F2ABE335;Initial Catalog=AIS20151222162701};" +
                                    "UserName=administrator;UserID=16394;DBMS Name=Microsoft SQL Server;" +
                                    "DBMS Version=2000/2005;SubID=super;AcctType=gy;Setuptype=Industry;Language=chs;" +
                                    "IP=192.168.248.128;K3Version=KUE;MachineName=AA-34E1F2ABE335;UUID=2A070315-B37B-4CAD-B559-7020F95AB1E5";

        public object ServerMgr => null;

        public string UserName => "administrator";

        public bool CheckLogin() => true;
    }
}
