// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 01-22-2017
//
// Last Modified By : David McCarter
// Last Modified On : 06-03-2019
// ***********************************************************************
// <copyright file="SpecialFolder.cs" company="dotNetTips.Utility.Standard">
//     Copyright (c) dotNetTips.com - McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************


namespace dotNetTips.Utility.Standard.IO
{
    /// <summary>
    /// Enum SpecialFolder
    /// </summary>
    /// TODO Edit XML Comment Template for SpecialFolder
    public enum SpecialFolder
    {
        // Summary: The logical Desktop rather than the physical file system location.
        /// <summary>
        /// The desktop
        /// </summary>
        /// TODO Edit XML Comment Template for Desktop
        Desktop = 0,
        //
        // Summary:
        //     The directory that contains the user's program groups.
        /// <summary>
        /// The programs
        /// </summary>
        /// TODO Edit XML Comment Template for Programs
        Programs = 2,
        //
        // Summary:
        //     The directory that serves as a common repository for documents.
        /// <summary>
        /// The personal
        /// </summary>
        /// TODO Edit XML Comment Template for Personal
        Personal = 5,
        //
        // Summary:
        //     The My Documents folder.
        /// <summary>
        /// The user documents
        /// </summary>
        /// TODO Edit XML Comment Template for UserDocuments
        UserDocuments = 60,
        //
        // Summary:
        //     The directory that serves as a common repository for the user's favorite items.
        /// <summary>
        /// The favorites
        /// </summary>
        /// TODO Edit XML Comment Template for Favorites
        Favorites = 6,
        //
        // Summary:
        //     The directory that corresponds to the user's Startup program group.
        /// <summary>
        /// The startup
        /// </summary>
        /// TODO Edit XML Comment Template for Startup
        Startup = 7,
        //
        // Summary:
        //     The directory that contains the user's most recently used documents.
        /// <summary>
        /// The recent
        /// </summary>
        /// TODO Edit XML Comment Template for Recent
        Recent = 8,
        //
        // Summary:
        //     The directory that contains the Send To menu items.
        /// <summary>
        /// The send to
        /// </summary>
        /// TODO Edit XML Comment Template for SendTo
        SendTo = 9,
        //
        // Summary:
        //     The directory that contains the Start menu items.
        /// <summary>
        /// The start menu
        /// </summary>
        /// TODO Edit XML Comment Template for StartMenu
        StartMenu = 11,
        //
        // Summary:
        //     The My Music folder.
        /// <summary>
        /// My music
        /// </summary>
        /// TODO Edit XML Comment Template for MyMusic
        MyMusic = 13,
        //
        // Summary:
        //     The file system directory that serves as a repository for videos that belong
        //     to a user. Added in the .NET Framework 4.
        /// <summary>
        /// My videos
        /// </summary>
        /// TODO Edit XML Comment Template for MyVideos
        MyVideos = 14,
        //
        // Summary:
        //     The directory used to physically store file objects on the desktop.
        /// <summary>
        /// The desktop directory
        /// </summary>
        /// TODO Edit XML Comment Template for DesktopDirectory
        DesktopDirectory = 16,
        //
        // Summary:
        //     The My Computer folder.
        /// <summary>
        /// My computer
        /// </summary>
        /// TODO Edit XML Comment Template for MyComputer
        MyComputer = 17,
        //
        // Summary:
        //     A file system directory that contains the link objects that may exist in the
        //     My Network Places virtual folder. Added in the .NET Framework 4.
        /// <summary>
        /// The network shortcuts
        /// </summary>
        /// TODO Edit XML Comment Template for NetworkShortcuts
        NetworkShortcuts = 19,
        //
        // Summary:
        //     A virtual folder that contains fonts. Added in the .NET Framework 4.
        /// <summary>
        /// The fonts
        /// </summary>
        /// TODO Edit XML Comment Template for Fonts
        Fonts = 20,
        //
        // Summary:
        //     The directory that serves as a common repository for document templates.
        /// <summary>
        /// The templates
        /// </summary>
        /// TODO Edit XML Comment Template for Templates
        Templates = 21,
        //
        // Summary:
        //     The file system directory that contains the programs and folders that appear
        //     on the Start menu for all users. This special folder is valid only for Windows
        //     NT systems. Added in the .NET Framework 4.
        /// <summary>
        /// The common start menu
        /// </summary>
        /// TODO Edit XML Comment Template for CommonStartMenu
        CommonStartMenu = 22,
        //
        // Summary:
        //     A folder for components that are shared across applications. This special folder
        //     is valid only for Windows NT, Windows 2000, and Windows XP systems. Added in
        //     the .NET Framework 4.
        /// <summary>
        /// The common programs
        /// </summary>
        /// TODO Edit XML Comment Template for CommonPrograms
        CommonPrograms = 23,
        //
        // Summary:
        //     The file system directory that contains the programs that appear in the Startup
        //     folder for all users. This special folder is valid only for Windows NT systems.
        //     Added in the .NET Framework 4.
        /// <summary>
        /// The common startup
        /// </summary>
        /// TODO Edit XML Comment Template for CommonStartup
        CommonStartup = 24,
        //
        // Summary:
        //     The file system directory that contains files and folders that appear on the
        //     desktop for all users. This special folder is valid only for Windows NT systems.
        //     Added in the .NET Framework 4.
        /// <summary>
        /// The common desktop directory
        /// </summary>
        /// TODO Edit XML Comment Template for CommonDesktopDirectory
        CommonDesktopDirectory = 25,
        //
        // Summary:
        //     The directory that serves as a common repository for application-specific data
        //     for the current roaming user.
        /// <summary>
        /// The application data
        /// </summary>
        /// TODO Edit XML Comment Template for ApplicationData
        ApplicationData = 26,
        //
        // Summary:
        //     The file system directory that contains the link objects that can exist in the
        //     Printers virtual folder. Added in the .NET Framework 4.
        /// <summary>
        /// The printer shortcuts
        /// </summary>
        /// TODO Edit XML Comment Template for PrinterShortcuts
        PrinterShortcuts = 27,
        //
        // Summary:
        //     The directory that serves as a common repository for application-specific data
        //     that is used by the current, non-roaming user.
        /// <summary>
        /// The local application data
        /// </summary>
        /// TODO Edit XML Comment Template for LocalApplicationData
        LocalApplicationData = 28,
        //
        // Summary:
        //     The directory that serves as a common repository for temporary Internet files.
        /// <summary>
        /// The internet cache
        /// </summary>
        /// TODO Edit XML Comment Template for InternetCache
        InternetCache = 32,
        //
        // Summary:
        //     The directory that serves as a common repository for Internet cookies.
        /// <summary>
        /// The cookies
        /// </summary>
        /// TODO Edit XML Comment Template for Cookies
        Cookies = 33,
        //
        // Summary:
        //     The directory that serves as a common repository for Internet history items.
        /// <summary>
        /// The history
        /// </summary>
        /// TODO Edit XML Comment Template for History
        History = 34,
        //
        // Summary:
        //     The directory that serves as a common repository for application-specific data
        //     that is used by all users.
        /// <summary>
        /// The common application data
        /// </summary>
        /// TODO Edit XML Comment Template for CommonApplicationData
        CommonApplicationData = 35,
        //
        // Summary:
        //     The Windows directory or SYSROOT. This corresponds to the %windir% or %SYSTEMROOT%
        //     environment variables. Added in the .NET Framework 4.
        /// <summary>
        /// The windows
        /// </summary>
        /// TODO Edit XML Comment Template for Windows
        Windows = 36,
        //
        // Summary:
        //     The System directory.
        /// <summary>
        /// The system
        /// </summary>
        /// TODO Edit XML Comment Template for System
        System = 37,
        //
        // Summary:
        //     The program files directory.On a non-x86 system, passing System.Environment.SpecialFolder.ProgramFiles
        //     to the System.Environment.GetFolderPath(System.Environment.SpecialFolder) method
        //     returns the path for non-x86 programs. To get the x86 program files directory
        //     on a non-x86 system, use the System.Environment.SpecialFolder.ProgramFilesX86
        //     member.
        /// <summary>
        /// The program files
        /// </summary>
        /// TODO Edit XML Comment Template for ProgramFiles
        ProgramFiles = 38,
        //
        // Summary:
        //     The My Pictures folder.
        /// <summary>
        /// My pictures
        /// </summary>
        /// TODO Edit XML Comment Template for MyPictures
        MyPictures = 39,
        //
        // Summary:
        //     The user's profile folder. Applications should not create files or folders at
        //     this level; they should put their data under the locations referred to by System.Environment.SpecialFolder.ApplicationData.
        //     Added in the .NET Framework 4.
        /// <summary>
        /// The user profile
        /// </summary>
        /// TODO Edit XML Comment Template for UserProfile
        UserProfile = 40,
        //
        // Summary:
        //     The Windows System folder. Added in the .NET Framework 4.
        /// <summary>
        /// The system X86
        /// </summary>
        /// TODO Edit XML Comment Template for SystemX86
        SystemX86 = 41,
        //
        // Summary:
        //     The x86 Program Files folder. Added in the .NET Framework 4.
        /// <summary>
        /// The program files X86
        /// </summary>
        /// TODO Edit XML Comment Template for ProgramFilesX86
        ProgramFilesX86 = 42,
        //
        // Summary:
        //     The directory for components that are shared across applications.To get the x86
        //     common program files directory on a non-x86 system, use the System.Environment.SpecialFolder.ProgramFilesX86
        //     member.
        /// <summary>
        /// The common program files
        /// </summary>
        /// TODO Edit XML Comment Template for CommonProgramFiles
        CommonProgramFiles = 43,
        //
        // Summary:
        //     The Program Files folder. Added in the .NET Framework 4.
        /// <summary>
        /// The common program files X86
        /// </summary>
        /// TODO Edit XML Comment Template for CommonProgramFilesX86
        CommonProgramFilesX86 = 44,
        //
        // Summary:
        //     The file system directory that contains the templates that are available to all
        //     users. This special folder is valid only for Windows NT systems. Added in the
        //     .NET Framework 4.
        /// <summary>
        /// The common templates
        /// </summary>
        /// TODO Edit XML Comment Template for CommonTemplates
        CommonTemplates = 45,
        //
        // Summary:
        //     The file system directory that contains documents that are common to all users.
        //     This special folder is valid for Windows NT systems, Windows 95, and Windows
        //     98 systems with Shfolder.dll installed. Added in the .NET Framework 4.
        /// <summary>
        /// The common documents
        /// </summary>
        /// TODO Edit XML Comment Template for CommonDocuments
        CommonDocuments = 46,
        //
        // Summary:
        //     The file system directory that contains administrative tools for all users of
        //     the computer. Added in the .NET Framework 4.
        /// <summary>
        /// The common admin tools
        /// </summary>
        /// TODO Edit XML Comment Template for CommonAdminTools
        CommonAdminTools = 47,
        //
        // Summary:
        //     The file system directory that is used to store administrative tools for an individual
        //     user. The Microsoft Management Console (MMC) will save customized consoles to
        //     this directory, and it will roam with the user. Added in the .NET Framework 4.
        /// <summary>
        /// The admin tools
        /// </summary>
        /// TODO Edit XML Comment Template for AdminTools
        AdminTools = 48,
        //
        // Summary:
        //     The file system directory that serves as a repository for music files common
        //     to all users. Added in the .NET Framework 4.
        /// <summary>
        /// The common music
        /// </summary>
        /// TODO Edit XML Comment Template for CommonMusic
        CommonMusic = 53,
        //
        // Summary:
        //     The file system directory that serves as a repository for image files common
        //     to all users. Added in the .NET Framework 4.
        /// <summary>
        /// The common pictures
        /// </summary>
        /// TODO Edit XML Comment Template for CommonPictures
        CommonPictures = 54,
        //
        // Summary:
        //     The file system directory that serves as a repository for video files common
        //     to all users. Added in the .NET Framework 4.
        /// <summary>
        /// The common videos
        /// </summary>
        /// TODO Edit XML Comment Template for CommonVideos
        CommonVideos = 55,
        //
        // Summary:
        //     The file system directory that contains resource data. Added in the .NET Framework
        //     4.
        /// <summary>
        /// The resources
        /// </summary>
        /// TODO Edit XML Comment Template for Resources
        Resources = 56,
        //
        // Summary:
        //     The file system directory that contains localized resource data. Added in the
        //     .NET Framework 4.
        /// <summary>
        /// The localized resources
        /// </summary>
        /// TODO Edit XML Comment Template for LocalizedResources
        LocalizedResources = 57,
        //
        // Summary:
        //     This value is recognized in Windows Vista for backward compatibility, but the
        //     special folder itself is no longer used. Added in the .NET Framework 4.
        /// <summary>
        /// The common oem links
        /// </summary>
        /// TODO Edit XML Comment Template for CommonOemLinks
        CommonOemLinks = 58,
        //
        // Summary:
        //     The file system directory that acts as a staging area for files waiting to be
        //     written to a CD. Added in the .NET Framework 4.
        /// <summary>
        /// The cd burning
        /// </summary>
        /// TODO Edit XML Comment Template for CDBurning
        CDBurning = 59,

        /// <summary>
        /// The Microsoft .NET foler.
        /// </summary>
        MicrosoftNet = 500
    }
}
