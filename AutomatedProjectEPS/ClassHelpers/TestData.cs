namespace AutomatedProjectEPS.ClassHelpers
{
    public class AppsPuth
    {
        #region BETA
        public const string ClientOEM = @"C:\Users\ribal\AppData\Local\BETA OEM Flash Tool\FlashToolClient.exe";
        public const string AdminOEM = @"C:\Users\ribal\AppData\Local\BETA OEM Flash Tool Admin\FlashToolAdmin.exe";

        public const string Client034 = @"C:\Users\ribal\AppData\Local\BETA 034 Flash Tool\FlashToolClient.exe";
        public const string Admin034 = @"C:\Users\ribal\AppData\Local\BETA 034 Flash Tool Admin\FlashToolAdmin.exe";

        public const string ClientCC = @"C:\Users\ribal\\AppData\Local\BETA CC Flash Tool\FlashToolClient.exe";
        public const string AdminCC = @"C:\Users\ribal\AppData\Local\BETA CC Flash Tool Admin\FlashToolAdmin.exe";

        public const string ClientSRT = @"C:\Users\ribal\AppData\Local\BETA SRT Flash Tool\FlashToolClient.exe";
        public const string AdminSRT = @"C:\Users\ribal\AppData\Local\BETA SRT Flash Tool Admin\FlashToolAdmin.exe";

        public const string ClientVWR = @"C:\Users\ribal\AppData\Local\BETA VWR Flash Tool\FlashToolClient.exe";
        public const string AdminVWR = @"C:\Users\ribal\AppData\Local\BETA VWR Flash Tool Admin\FlashToolAdmin.exe";

        public const string ClientJHM = @"C:\Users\ribal\AppData\Local\BETA JHM Power Connect\FlashToolClient.exe";
        public const string AdminJHM = @"C:\Users\ribal\AppData\Local\BETA JHM Power Connect Admin\FlashToolAdmin.exe";
        #endregion

        #region PROD
        /*public const string ClientOEM = @"C:\Users\ribal\AppData\Local\OEM Flash Tool\FlashToolClient.exe";
        public const string AdminOEM = @"C:\Users\ribal\AppData\Local\OEM Flash Tool Admin\FlashToolAdmin.exe";

        public const string Client034 = @"C:\Users\ribal\AppData\Local\034 Flash Tool\FlashToolClient.exe";       
        public const string Admin034 = @"C:\Users\ribal\AppData\Local\034 Flash Tool Admin\FlashToolAdmin.exe";    

        public const string ClientCC = @"C:\Users\ribal\\AppData\Local\CC Flash Tool\FlashToolClient.exe";
        public const string AdminCC = @"C:\Users\ribal\AppData\Local\CC Flash Tool Admin\FlashToolAdmin.exe";

        public const string ClientSRT = @"C:\Users\ribal\AppData\Local\SRT Flash Tool\FlashToolClient.exe";
        public const string AdminSRT = @"C:\Users\ribal\AppData\Local\SRT Flash Tool Admin\FlashToolAdmin.exe";

        public const string ClientVWR = @"C:\Users\ribal\AppData\Local\VWR Flash Tool\FlashToolClient.exe";
        public const string AdminVWR = @"C:\Users\ribal\AppData\Local\VWR Flash Tool Admin\FlashToolAdmin.exe";

        public const string ClientJHM = @"C:\Users\ribal\AppData\Local\JHM Power Connect\FlashToolClient.exe";
        public const string AdminJHM = @"C:\Users\ribal\AppData\Local\JHM Power Connect Admin\FlashToolAdmin.exe";*/
        #endregion

    }

    public class DriverPuth
    {
        public const string WinDriverPuth = @"WinAppDriver\WinAppDriver.exe";
    }

    public class Credentials
    {
        #region Admin Credentials
        public const string LoginAdminOEM = "oemAdmin";
        public const string PasswordAdminOEM = "$c9YH=";

        public const string LoginAdmin034 = "userj034";
        public const string PasswordAdmin034 = "$c9YH=";

        public const string LoginAdminCC = "KevinCC";
        public const string PasswordAdminCC = "$c9YH=";

        public const string LoginAdminSRT = "BugsBunny";
        public const string PasswordAdminSRT = "321654987";

        public const string LoginAdminVWR = "KevinVWR";
        public const string PasswordAdminVWR = "$c9YH=";

        public const string LoginAdminJHM = "KevinJHM";
        public const string PasswordAdminJHM = "$c9YH=";
        #endregion

        #region Client Credentials
        public const string LoginClientOEM = "ClientOEM";
        public const string LoginClient034 = "Client034";
        public const string LoginClientCC = "ClientCC";
        public const string LoginClientSRT = "ClientSRT";
        public const string LoginClientVWR = "ClientVWR";
        public const string LoginClientJHM = "ClientJHM";

        public const string PasswordClient = "Test123!";
        #endregion
    }

    public class BinariesPuth
    {
        public const string BaseEcu = "Simos 084 - 8K0907551C S0005.bin";
        public const string PerformanceEcu = "Simos 084 - 8K0907551C S0005 - Performance.bin";

        public const string BaseTcu = "8K2927156J S0005.bin";
        public const string PerformanceTcu = "8K2927156J S0005 Performance.bin";

    }

    public class DB
    {
        public const string GetConnectionString = "Data Source=eps-test.css1q55w88u9.eu-central-1.rds.amazonaws.com;Initial Catalog=EPS-03-02-2018;Integrated Security=False;User Id=Administrator;Password=fgdsrt4fgrrg;multipleactiveresultsets=True;application name=EntityFramework";
    }

    public class BinaryPartNumbers
    {
        public const string ECU = "8K0907551C 0005";
        public const string TCU = "8K2927156J 0005";
    }

    public class BinaryType
    {
        public const string Base = "Serie emulation";
        public const string Performance = "Performance";
    }

    public class Lazarus
    {
        public const string AppLazarus = @"C:\Users\ribal\source\repos\AutomatedProjectEPS\Lazarus\Lazarus.exe";
        public const string FolderName = @"\Lazarus";
    }

    public class ControllerName
    {
        public const string ECU = "Simos 8.4";
        public const string TCU = "DSG DL501 (G2)";

    }

    public class CompanyFilter
    {
        public const string _034 = "034-";
        public const string CC = "CC-";
        public const string SRT = "SRT-";
        public const string OEM = "OEM-";
        public const string VWR = "VWR-";
        public const string JHM = "JHM-";
    }

    public class Distributors
    {
        public const string OEM = "TestCompanyOEM";
        public const string JHM = "TestCompanyJHM";
        public const string _034 = "TestCompany034";
        public const string CC = "TestCompanyCC";
        public const string SRT = "TestCompanySRT";
        public const string VWR = "TestCompanyVWR";
    }


}
