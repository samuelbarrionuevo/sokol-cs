
//-------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the following tool:
//        https://github.com/lithiumtoast/c2cs (v1.1.0.0)
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ReSharper disable All
//-------------------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using C2CS;

#nullable enable
#pragma warning disable 1591

public static unsafe partial class sokol_args
{
    private const string LibraryName = "sokol";

    // Function @ sokol_args.h:302:33 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_args.h)
    [DllImport(LibraryName)]
    public static extern CString sargs_value_at(int index);

    // Function @ sokol_args.h:300:33 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_args.h)
    [DllImport(LibraryName)]
    public static extern CString sargs_key_at(int index);

    // Function @ sokol_args.h:298:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_args.h)
    [DllImport(LibraryName)]
    public static extern int sargs_num_args();

    // Function @ sokol_args.h:296:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_args.h)
    [DllImport(LibraryName)]
    public static extern int sargs_find(CString key);

    // Function @ sokol_args.h:294:26 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_args.h)
    [DllImport(LibraryName)]
    public static extern CBool sargs_boolean(CString key);

    // Function @ sokol_args.h:292:26 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_args.h)
    [DllImport(LibraryName)]
    public static extern CBool sargs_equals(CString key, CString val);

    // Function @ sokol_args.h:290:33 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_args.h)
    [DllImport(LibraryName)]
    public static extern CString sargs_value_def(CString key, CString def);

    // Function @ sokol_args.h:288:33 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_args.h)
    [DllImport(LibraryName)]
    public static extern CString sargs_value(CString key);

    // Function @ sokol_args.h:286:26 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_args.h)
    [DllImport(LibraryName)]
    public static extern CBool sargs_exists(CString key);

    // Function @ sokol_args.h:284:26 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_args.h)
    [DllImport(LibraryName)]
    public static extern CBool sargs_isvalid();

    // Function @ sokol_args.h:282:26 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_args.h)
    [DllImport(LibraryName)]
    public static extern void sargs_shutdown();

    // Function @ sokol_args.h:280:26 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_args.h)
    [DllImport(LibraryName)]
    public static extern void sargs_setup(sargs_desc* desc);

    // Struct @ sokol_args.h:277:3 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_args.h)
    [StructLayout(LayoutKind.Explicit, Size = 24, Pack = 8)]
    public struct sargs_desc
    {
        [FieldOffset(0)] // size = 4, padding = 4
        public int argc;

        [FieldOffset(8)] // size = 8, padding = 0
        public CString* argv;

        [FieldOffset(16)] // size = 4, padding = 0
        public int max_args;

        [FieldOffset(20)] // size = 4, padding = 0
        public int buf_size;
    }
}
