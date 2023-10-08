// ReSharper disable InconsistentNaming
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable IdentifierTypo
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace HamedStack.MSBuilder;

/// <summary>
/// Represents a class containing constants for MSBuild project types.
/// </summary>
public static class MSBuildProjectType
{
    public const string AspNet5 = "{8BB2217D-0F2D-49D1-97BC-3654ED321F3B}";
    public const string AspNetCoreEmpty = "{356CAE8B-CFD3-4221-B0A8-081A261C0C10}";
    public const string AspNetCoreWebAPI = "{687AD6DE-2DF8-4B75-A007-DEF66CD68131}";
    public const string AspNetCoreWebApp = "{E27D8B1D-37A3-4EFC-AFAE-77744ED86BCA}";
    public const string AspNetCoreWebApp_MVC = "{065C0379-B32B-4E17-B529-0A722277FE2D}";
    public const string AspNetCoreWithAngular = "{32F807D6-6071-4239-8605-A9B2205AAD60}";
    public const string AspNetCoreWithReactJs = "{4C3A4DF3-0AAD-4113-8201-4EEEA5A70EED}";
    public const string AspNetMvc1 = "{603C0E0B-DB56-11DC-BE95-000D561079B0}";
    public const string AspNetMvc2 = "{F85E285D-A4E0-4152-9332-AB1D724D3325}";
    public const string AspNetMvc3 = "{E53F8FEA-EAE0-44A6-8774-FFD645390401}";
    public const string AspNetMvc4 = "{E3E379DF-F4C6-4180-9B81-6769533ABE47}";
    public const string AspNetMvc5 = "{349C5851-65DF-11DA-9384-00065B846F21}";
    public const string AzureFunctions = "{30E03E5A-5F87-4398-9D0D-FEB397AFC92D}";
    public const string AzureResourceGroupBlankTemplate = "{14B7E1DC-C58C-427C-9728-EED16291B2DA}";
    public const string AzureResourceGroupWebapp = "{E2FF0EA2-4842-46E0-A434-C62C75BAEC67}";
    public const string AzureWebJobNetFramework = "{BFBC8063-F137-4FC6-AEB4-F96101BA5C8A}";
    public const string BlazorServerApp = "{C8A4CD56-20F4-440B-8375-78386A4431B9}";
    public const string CSharp = "{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}";
    public const string CSharpNetCore = "{9A19103F-16F7-4668-BE54-9A1E7A4F7556}";
    public const string Cpp = "{8BC9CEB8-8B4A-11D0-8D11-00A0C91BC942}";
    public const string ClassLibrary = "{2EFF6E4D-FF75-4ADF-A9BE-74BEC0B0AFF8}";
    public const string ConsoleApp = "{008A663C-3F22-40EF-81B0-012B6C27E2FB}";
    public const string Database = "{A9ACE9BB-CECE-4E62-9AA4-C7E7C5BD2124}";
    public const string DatabaseOtherTypes = "{4F174C21-8C12-11D0-8340-0000F80270F8}";
    public const string DeploymentCab = "{3EA9E505-35AC-4774-B492-AD1749C4943A}";
    public const string DeploymentMergeModule = "{06A35CCD-C46D-44D5-987B-CF40FF872267}";
    public const string DeploymentSetup = "{978C614F-708E-4E1A-B201-565925725DBA}";
    public const string DeploymentSmartDeviceCab = "{AB322303-2255-48EF-A496-5904EB18DA55}";
    public const string DistributedSystem = "{F135691A-BF7E-435D-8960-F99683D2D49C}";
    public const string Dynamics2012AXCSharpInAOT = "{BF6F8E12-879D-49E7-ADF0-5503146B24B8}";
    public const string Extensibility = "{82B43B9B-A64C-4715-B499-D71E9CA2BD60}";
    public const string FSharp = "{F2A71F9B-5D33-465A-A702-920D77279786}";
    public const string JSharp = "{E6FDF86B-F3D1-11D4-8576-0002A516ECE8}";
    public const string JScript = "{262852C6-CD72-467D-83FE-5EEB1973A190}";
    public const string Legacy2003SmartDeviceCSharp = "{20D4826A-C6FA-45DB-90F4-C717570B9F32}";
    public const string Legacy2003SmartDeviceVbNet = "{CB4CE8C6-1BDB-4DC7-A4D3-65A1999772F8}";
    public const string LightSwitch = "{8BB0C5E8-0616-4F60-8E55-A43933E57E9C}";
    public const string Lightswitch = "{DA98106F-DEFA-4A62-8804-0BD2F166A45D}";
    public const string LightSwitchProject = "{581633EB-B896-402F-8E60-36F3DA191C85}";
    public const string MicroFramework = "{B69E3092-B931-443C-ABE7-7E7b65f2A37F}";
    public const string Mvc2 = "{F85E285D-A4E0-4152-9332-AB1D724D3325}";
    public const string Mvc3 = "{E53F8FEA-EAE0-44A6-8774-FFD645390401}";
    public const string Mvc4 = "{E3E379DF-F4C6-4180-9B81-6769533ABE47}";
    public const string Mvc5 = "{349C5851-65DF-11DA-9384-00065B846F21}";
    public const string MonoForAndroid = "{EFBA0AD7-5A72-4C68-AF49-83D382785DCF}";
    public const string MonoDevelopAddIn = "{86F6BF2A-E449-4B3E-813B-9ACC37E5545F}";
    public const string MonoTouch = "{6BC8ED88-2882-458C-8E55-DFD12B67127B}";
    public const string MonoTouchBinding = "{F5B4F3BC-B597-4E2B-B552-EF5D8A32436F}";
    public const string Office_SharePointApp = "{C1CDDADD-2546-481F-9697-4EA41081F2FC}";
    public const string PlatformToolset_v120 = "{8DB26A54-E6C6-494F-9B32-ACBB256CD3A5}";
    public const string PlatformToolset_v141 = "{C2CAFE0E-DCE1-4D03-BBF6-18283CF86E48}";
    public const string PortableClassLibrary = "{786C830F-07A1-408B-BD7F-6EE04809D6DB}";
    public const string PowerShell = "{F5034706-568F-408A-B7B3-4D38C6DB8A32}";
    public const string ProjectFolders = "{66A26720-8FB5-11D2-AA7E-00C04F688DDE}";
    public const string SharePointCSharp = "{593B0543-81F6-4436-BA1E-4747859CAAE2}";
    public const string SharePointVbNet = "{EC05E597-79D4-47F3-ADA0-324C4F7C7484}";
    public const string SharePointWorkflow = "{F8810EC1-6754-47FC-A15F-DFABD2E3FA90}";
    public const string Silverlight = "{A1591282-1198-4647-A2B1-27E5FF5F6F3B}";
    public const string SmartDeviceCSharp = "{4D628B5B-2FBC-4AA6-8C16-197242AEB884}";
    public const string SmartDeviceVbNet = "{68B1623D-7FB9-47D8-8664-7ECEA3297D4F}";
    public const string SolutionFolder = "{2150E333-8FDC-42A3-9474-1A3956D46DE8}";
    public const string SSIS1 = "{159641D6-6404-4A2A-AE62-294DE0FE8301}";
    public const string SSIS2 = "{D183A3D8-5FD8-494B-B014-37F57B35E655}";
    public const string SSIS3 = "{C9674DCB-5085-4A16-B785-4C70DD1589BD}";
    public const string SSRS = "{F14B399A-7131-4C87-9E4B-1186C45EF12D}";
    public const string StoreAppUniversal = "{D954291E-2A0B-460D-934E-DC6B0785DB48}";
    public const string Test = "{3AC096D0-A1C2-E12C-1390-A8335801FDAB}";
    public const string UniversalWindowsClassLibraryUWP = "{A5A43C5B-DE2A-4C0C-9213-0A381AF9435A}";
    public const string VbNet = "{F184B08F-C81C-45F6-A57F-5ABD9991F28F}";
    public const string VisualDatabaseTools = "{C252FEB5-A946-4202-B1D4-9916A0590387}";
    public const string VisualStudio2015InstallerProjectExtension = "{54435603-DBB4-11D2-8724-00A0C9A8B90C}";
    public const string VisualStudioToolsForApplications_VSTA = "{A860303F-1F3F-4691-B57E-529FC101A107}";
    public const string VisualStudioToolsForOfficeVSTO = "{BAA0C2D2-18E2-41B9-852F-F413020CAA33}";
    public const string WebApplication = "{349C5851-65DF-11DA-9384-00065B846F21}";
    public const string WebSite = "{E24C65DC-7377-472B-9ABA-BC803B73C61A}";
    public const string WindowsCSharp = "{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}";
    public const string WindowsVbNet = "{F184B08F-C81C-45F6-A57F-5ABD9991F28F}";
    public const string WindowsVisualCpp = "{8BC9CEB8-8B4A-11D0-8D11-00A0C91BC942}";
    public const string WindowsApplicationPackagingProject_MSIX = "{C7167F0D-BC9F-4E6E-AFE1-012C56B48DB5}";
    public const string WindowsCommunicationFoundation_WCF = "{3D9AD99F-2412-4246-B90B-4EAA41C64699}";
    public const string WindowsPhone8_81_Blank_Hub_WebviewApp = "{76F1466A-8B6D-4E39-A767-685A06062A39}";
    public const string WindowsPhone8_81App_CSharp = "{C089C8C0-30E0-4E22-80C0-CE093F111A43}";
    public const string WindowsPhone8_81App_VbNet = "{DB03555F-0C8B-43BE-9FF9-57896B3C5E56}";
    public const string WindowsPresentationFoundation_WPF = "{60DC8134-EBA5-43B8-BCC9-BB4BC16C2548}";
    public const string WindowsStoreMetroAppsAndComponents = "{BC8A1FFA-BEE3-4634-8014-F334798102B3}";
    public const string WorkflowCSharp = "{14822709-B5A1-4724-98CA-57A101D1B079}";
    public const string WorkflowVbNet = "{D59BE175-2ED0-4C54-BE3D-CDAA9F3214C8}";
    public const string WorkflowFoundation = "{32F31D43-81CC-4C15-9DE6-3FC5453562B6}";
    public const string Xamarin_Android = "{EFBA0AD7-5A72-4C68-AF49-83D382785DCF}";
    public const string Xamarin_iOS = "{6BC8ED88-2882-458C-8E55-DFD12B67127B}";
    public const string XNA_Windows = "{6D335F3A-9D43-41b4-9D22-F6F17C4BE596}";
    public const string XNA_XBox = "{2DF5C3F4-5A5F-47A9-8E94-23B4456F55E2}";
    public const string XNA_Zune = "{D399B71A-8929-442A-A9AC-8BEC78BB2433}";
}