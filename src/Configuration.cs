﻿using System.IO;

namespace Win10BloatRemover
{
    /**
     *  Configuration
     *  This class stores the configuration data of the app
     */
    static class Configuration
    {
        public static readonly string InstallWimTweakPath = Path.Combine(Path.GetTempPath(), "install_wim_tweak.exe");

        public static readonly string[] ServicesToRemove = {
            "DiagTrack",
            "diagsvc",
            "diagnosticshub.standardcollector.service",
            "dmwappushservice",
            "WerSvc",
            "wercplsupport",
            "PcaSvc",           // Program Compatibility Assistant
            "RetailDemo",
            "DPS",
            "WdiServiceHost",
            "WdiSystemHost"
        };

        public static readonly UWPAppGroup[] UWPAppsToRemove = {
            UWPAppGroup.Zune,
            UWPAppGroup.MailAndCalendar,
            UWPAppGroup.OneNote,
            UWPAppGroup.OfficeHub,
            UWPAppGroup.Camera,
            UWPAppGroup.Maps,
            UWPAppGroup.Mobile,
            UWPAppGroup.HelpAndFeedback,
            UWPAppGroup.Bing,
            UWPAppGroup.Messaging,
            UWPAppGroup.People,
            UWPAppGroup.Skype
        };

        public static readonly string[] ScheduledTasksToDisable = {
            @"Microsoft\Windows\AppID\SmartScreenSpecific",
            @"Microsoft\Windows\Application Experience\AitAgent",
            @"Microsoft\Windows\Application Experience\Microsoft Compatibility Appraiser",
            @"Microsoft\Windows\Application Experience\ProgramDataUpdater",
            @"Microsoft\Windows\Application Experience\StartupAppTask",
            @"Microsoft\Windows\Autochk\Proxy",
            @"Microsoft\Windows\CloudExperienceHost\CreateObjectTask",
            @"Microsoft\Windows\Customer Experience Improvement Program\BthSQM",
            @"Microsoft\Windows\Customer Experience Improvement Program\Consolidator",
            @"Microsoft\Windows\Customer Experience Improvement Program\KernelCeipTask",
            @"Microsoft\Windows\Customer Experience Improvement Program\Uploader",
            @"Microsoft\Windows\Customer Experience Improvement Program\UsbCeip",
            @"Microsoft\Windows\DiskDiagnostic\Microsoft-Windows-DiskDiagnosticDataCollector",
            @"Microsoft\Windows\DiskFootprint\Diagnostics",
            @"Microsoft\Windows\FileHistory\File History (maintenance mode)",
            @"Microsoft\Windows\Maintenance\WinSAT",
            @"Microsoft\Windows\PI\Sqm-Tasks",
            @"Microsoft\Windows\Power Efficiency Diagnostics\AnalyzeSystem",
            @"Microsoft\Windows\Shell\FamilySafetyMonitor",
            @"Microsoft\Windows\Shell\FamilySafetyRefresh",
            @"Microsoft\Windows\Shell\FamilySafetyUpload",
            @"Microsoft\Windows\Windows Error Reporting\QueueReporting",
            @"Microsoft\Windows\WindowsUpdate\Automatic App Update",
            @"Microsoft\Windows\License Manager\TempSignedLicenseExchange",
            @"Microsoft\Windows\WindowsUpdate\Automatic App Update",
            @"Microsoft\Windows\Clip\License Validation",
            @"\Microsoft\Windows\ApplicationData\DsSvcCleanup",
            @"\Microsoft\Windows\Power Efficiency Diagnostics\AnalyzeSystem",
            @"\Microsoft\Windows\PushToInstall\LoginCheck",
            @"\Microsoft\Windows\PushToInstall\Registration",
            @"\Microsoft\Windows\Shell\FamilySafetyMonitor",
            @"\Microsoft\Windows\Shell\FamilySafetyMonitorToastTask",
            @"\Microsoft\Windows\Shell\FamilySafetyRefreshTask",
            @"\Microsoft\Windows\Subscription\EnableLicenseAcquisition",
            @"\Microsoft\Windows\Subscription\LicenseAcquisition"
        };

        public static readonly string[] WindowsFeaturesToRemove = {
            "InternetExplorer-Optional-Package",
            "Hello-Face-Package",
            "QuickAssist-Package"
        };
    }
}
