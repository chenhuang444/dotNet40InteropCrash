using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace InteropTest.Adapter
{
    [SuppressUnmanagedCodeSecurity]
    public unsafe class MyAdapter
    {
        private const string DLLName = "VersionNumber";

        private const string EntryPointName = "GetMyVersion";

        [DllImport(DLLName, EntryPoint = EntryPointName, CharSet = CharSet.Ansi)]
        internal static extern IntPtr GetMyVersionPtr();

        [DllImport(DLLName, EntryPoint = EntryPointName, CharSet = CharSet.Ansi)]
        internal static extern string GetMyVersionString();
    }
}
