
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

public static unsafe partial class sokol_app
{
    private const string LibraryName = "sokol";

    // Function @ sokol_app.h:1511:32 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void* sapp_android_get_native_activity();

    // Function @ sokol_app.h:1508:32 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void* sapp_wgpu_get_depth_stencil_view();

    // Function @ sokol_app.h:1506:32 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void* sapp_wgpu_get_resolve_view();

    // Function @ sokol_app.h:1504:32 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void* sapp_wgpu_get_render_view();

    // Function @ sokol_app.h:1502:32 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void* sapp_wgpu_get_device();

    // Function @ sokol_app.h:1499:32 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void* sapp_win32_get_hwnd();

    // Function @ sokol_app.h:1497:32 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void* sapp_d3d11_get_depth_stencil_view();

    // Function @ sokol_app.h:1495:32 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void* sapp_d3d11_get_render_target_view();

    // Function @ sokol_app.h:1493:32 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void* sapp_d3d11_get_swap_chain();

    // Function @ sokol_app.h:1491:32 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void* sapp_d3d11_get_device_context();

    // Function @ sokol_app.h:1489:32 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void* sapp_d3d11_get_device();

    // Function @ sokol_app.h:1486:32 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void* sapp_ios_get_window();

    // Function @ sokol_app.h:1484:32 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void* sapp_macos_get_window();

    // Function @ sokol_app.h:1482:32 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void* sapp_metal_get_drawable();

    // Function @ sokol_app.h:1480:32 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void* sapp_metal_get_renderpass_descriptor();

    // Function @ sokol_app.h:1478:32 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void* sapp_metal_get_device();

    // Function @ sokol_app.h:1475:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void sapp_html5_fetch_dropped_file(sapp_html5_fetch_request* request);

    // Function @ sokol_app.h:1473:29 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern uint sapp_html5_get_dropped_file_size(int index);

    // Function @ sokol_app.h:1471:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void sapp_html5_ask_leave_site(CBool ask);

    // Function @ sokol_app.h:1468:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern CBool sapp_gles2();

    // Function @ sokol_app.h:1465:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void sapp_run(sapp_desc* desc);

    // Function @ sokol_app.h:1462:32 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern CString sapp_get_dropped_file_path(int index);

    // Function @ sokol_app.h:1460:24 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern int sapp_get_num_dropped_files();

    // Function @ sokol_app.h:1458:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void sapp_set_icon(sapp_icon_desc* icon_desc);

    // Function @ sokol_app.h:1456:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void sapp_set_window_title(CString str);

    // Function @ sokol_app.h:1454:32 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern CString sapp_get_clipboard_string();

    // Function @ sokol_app.h:1452:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void sapp_set_clipboard_string(CString str);

    // Function @ sokol_app.h:1450:29 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern ulong sapp_frame_count();

    // Function @ sokol_app.h:1448:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void sapp_consume_event();

    // Function @ sokol_app.h:1446:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void sapp_quit();

    // Function @ sokol_app.h:1444:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void sapp_cancel_quit();

    // Function @ sokol_app.h:1442:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void sapp_request_quit();

    // Function @ sokol_app.h:1440:30 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern sapp_desc sapp_query_desc();

    // Function @ sokol_app.h:1438:26 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void* sapp_userdata();

    // Function @ sokol_app.h:1436:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern CBool sapp_mouse_locked();

    // Function @ sokol_app.h:1434:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void sapp_lock_mouse(CBool @lock);

    // Function @ sokol_app.h:1432:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern CBool sapp_mouse_shown();

    // Function @ sokol_app.h:1430:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void sapp_show_mouse(CBool show);

    // Function @ sokol_app.h:1428:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void sapp_toggle_fullscreen();

    // Function @ sokol_app.h:1426:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern CBool sapp_is_fullscreen();

    // Function @ sokol_app.h:1424:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern CBool sapp_keyboard_shown();

    // Function @ sokol_app.h:1422:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern void sapp_show_keyboard(CBool show);

    // Function @ sokol_app.h:1420:26 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern float sapp_dpi_scale();

    // Function @ sokol_app.h:1418:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern CBool sapp_high_dpi();

    // Function @ sokol_app.h:1416:24 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern int sapp_sample_count();

    // Function @ sokol_app.h:1414:24 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern int sapp_depth_format();

    // Function @ sokol_app.h:1412:24 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern int sapp_color_format();

    // Function @ sokol_app.h:1410:26 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern float sapp_heightf();

    // Function @ sokol_app.h:1408:24 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern int sapp_height();

    // Function @ sokol_app.h:1406:26 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern float sapp_widthf();

    // Function @ sokol_app.h:1404:24 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern int sapp_width();

    // Function @ sokol_app.h:1402:25 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern CBool sapp_isvalid();

    // Function @ sokol_app.h:1399:18 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [DllImport(LibraryName)]
    public static extern sapp_desc sokol_main(int argc, CString* argv);

    // FunctionPointer @ sokol_app.h:1392:12 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_SOKOL_APP_Sapp_html5_fetch_responsePtr_Void
    {
        public delegate* unmanaged<sapp_html5_fetch_response*, void> Pointer;
    }

    // FunctionPointer @ sokol_app.h:1340:12 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_SOKOL_APP_CString_VoidPtr_Void
    {
        public delegate* unmanaged<CString, void*, void> Pointer;
    }

    // FunctionPointer @ sokol_app.h:1339:12 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_SOKOL_APP_Sapp_eventPtr_VoidPtr_Void
    {
        public delegate* unmanaged<sapp_event*, void*, void> Pointer;
    }

    // FunctionPointer @ sokol_app.h:1336:12 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_SOKOL_APP_VoidPtr_Void
    {
        public delegate* unmanaged<void*, void> Pointer;
    }

    // FunctionPointer @ sokol_app.h:1333:12 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_SOKOL_APP_CString_Void
    {
        public delegate* unmanaged<CString, void> Pointer;
    }

    // FunctionPointer @ sokol_app.h:1332:12 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_SOKOL_APP_Sapp_eventPtr_Void
    {
        public delegate* unmanaged<sapp_event*, void> Pointer;
    }

    // FunctionPointer @ sokol_app.h:1329:12 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_SOKOL_APP_Void
    {
        public delegate* unmanaged<void> Pointer;
    }

    // Struct @ sokol_app.h:1396:3 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [StructLayout(LayoutKind.Explicit, Size = 40, Pack = 8)]
    public struct sapp_html5_fetch_request
    {
        [FieldOffset(0)] // size = 4, padding = 4
        public int dropped_file_index;

        [FieldOffset(8)] // size = 8, padding = 0
        public FnPtr_SOKOL_APP_Sapp_html5_fetch_responsePtr_Void callback;

        [FieldOffset(16)] // size = 8, padding = 0
        public void* buffer_ptr;

        [FieldOffset(24)] // size = 4, padding = 4
        public uint buffer_size;

        [FieldOffset(32)] // size = 8, padding = 0
        public void* user_data;
    }

    // Struct @ sokol_app.h:1388:3 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [StructLayout(LayoutKind.Explicit, Size = 40, Pack = 8)]
    public struct sapp_html5_fetch_response
    {
        [FieldOffset(0)] // size = 1, padding = 3
        public CBool succeeded;

        [FieldOffset(4)] // size = 4, padding = 0
        public sapp_html5_fetch_error error_code;

        [FieldOffset(8)] // size = 4, padding = 0
        public int file_index;

        [FieldOffset(12)] // size = 4, padding = 0
        public uint fetched_size;

        [FieldOffset(16)] // size = 8, padding = 0
        public void* buffer_ptr;

        [FieldOffset(24)] // size = 4, padding = 4
        public uint buffer_size;

        [FieldOffset(32)] // size = 8, padding = 0
        public void* user_data;
    }

    // Struct @ sokol_app.h:1369:3 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [StructLayout(LayoutKind.Explicit, Size = 368, Pack = 8)]
    public struct sapp_desc
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public FnPtr_SOKOL_APP_Void init_cb;

        [FieldOffset(8)] // size = 8, padding = 0
        public FnPtr_SOKOL_APP_Void frame_cb;

        [FieldOffset(16)] // size = 8, padding = 0
        public FnPtr_SOKOL_APP_Void cleanup_cb;

        [FieldOffset(24)] // size = 8, padding = 0
        public FnPtr_SOKOL_APP_Sapp_eventPtr_Void event_cb;

        [FieldOffset(32)] // size = 8, padding = 0
        public FnPtr_SOKOL_APP_CString_Void fail_cb;

        [FieldOffset(40)] // size = 8, padding = 0
        public void* user_data;

        [FieldOffset(48)] // size = 8, padding = 0
        public FnPtr_SOKOL_APP_VoidPtr_Void init_userdata_cb;

        [FieldOffset(56)] // size = 8, padding = 0
        public FnPtr_SOKOL_APP_VoidPtr_Void frame_userdata_cb;

        [FieldOffset(64)] // size = 8, padding = 0
        public FnPtr_SOKOL_APP_VoidPtr_Void cleanup_userdata_cb;

        [FieldOffset(72)] // size = 8, padding = 0
        public FnPtr_SOKOL_APP_Sapp_eventPtr_VoidPtr_Void event_userdata_cb;

        [FieldOffset(80)] // size = 8, padding = 0
        public FnPtr_SOKOL_APP_CString_VoidPtr_Void fail_userdata_cb;

        [FieldOffset(88)] // size = 4, padding = 0
        public int width;

        [FieldOffset(92)] // size = 4, padding = 0
        public int height;

        [FieldOffset(96)] // size = 4, padding = 0
        public int sample_count;

        [FieldOffset(100)] // size = 4, padding = 0
        public int swap_interval;

        [FieldOffset(104)] // size = 1, padding = 0
        public CBool high_dpi;

        [FieldOffset(105)] // size = 1, padding = 0
        public CBool fullscreen;

        [FieldOffset(106)] // size = 1, padding = 5
        public CBool alpha;

        [FieldOffset(112)] // size = 8, padding = 0
        public CString window_title;

        [FieldOffset(120)] // size = 1, padding = 0
        public CBool user_cursor;

        [FieldOffset(121)] // size = 1, padding = 2
        public CBool enable_clipboard;

        [FieldOffset(124)] // size = 4, padding = 0
        public int clipboard_size;

        [FieldOffset(128)] // size = 1, padding = 3
        public CBool enable_dragndrop;

        [FieldOffset(132)] // size = 4, padding = 0
        public int max_dropped_files;

        [FieldOffset(136)] // size = 4, padding = 4
        public int max_dropped_file_path_length;

        [FieldOffset(144)] // size = 200, padding = 0
        public sapp_icon_desc icon;

        [FieldOffset(344)] // size = 1, padding = 0
        public CBool gl_force_gles2;

        [FieldOffset(345)] // size = 1, padding = 0
        public CBool win32_console_utf8;

        [FieldOffset(346)] // size = 1, padding = 0
        public CBool win32_console_create;

        [FieldOffset(347)] // size = 1, padding = 4
        public CBool win32_console_attach;

        [FieldOffset(352)] // size = 8, padding = 0
        public CString html5_canvas_name;

        [FieldOffset(360)] // size = 1, padding = 0
        public CBool html5_canvas_resize;

        [FieldOffset(361)] // size = 1, padding = 0
        public CBool html5_preserve_drawing_buffer;

        [FieldOffset(362)] // size = 1, padding = 0
        public CBool html5_premultiplied_alpha;

        [FieldOffset(363)] // size = 1, padding = 0
        public CBool html5_ask_leave_site;

        [FieldOffset(364)] // size = 1, padding = 3
        public CBool ios_keyboard_resizes_canvas;
    }

    // Struct @ sokol_app.h:1325:3 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [StructLayout(LayoutKind.Explicit, Size = 200, Pack = 8)]
    public struct sapp_icon_desc
    {
        [FieldOffset(0)] // size = 1, padding = 7
        public CBool sokol_default;

        [FieldOffset(8)] // size = 192, padding = 0
        public fixed ulong _images[192 / 8]; // sapp_image_desc[8]

        public Span<sapp_image_desc> images
        {
            get
            {
                fixed (sapp_icon_desc* @this = &this)
                {
                    var pointer = &@this->_images[0];
                    var span = new Span<sapp_image_desc>(pointer, 8);
                    return span;
                }
            }
        }
    }

    // Struct @ sokol_app.h:1302:3 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [StructLayout(LayoutKind.Explicit, Size = 24, Pack = 8)]
    public struct sapp_image_desc
    {
        [FieldOffset(0)] // size = 4, padding = 0
        public int width;

        [FieldOffset(4)] // size = 4, padding = 0
        public int height;

        [FieldOffset(8)] // size = 16, padding = 0
        public sapp_range pixels;
    }

    // Struct @ sokol_app.h:1275:3 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 8)]
    public struct sapp_range
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public void* ptr;

        [FieldOffset(8)] // size = 8, padding = 0
        public ulong size;
    }

    // Struct @ sokol_app.h:1264:3 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [StructLayout(LayoutKind.Explicit, Size = 272, Pack = 8)]
    public struct sapp_event
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public ulong frame_count;

        [FieldOffset(8)] // size = 4, padding = 0
        public sapp_event_type type;

        [FieldOffset(12)] // size = 4, padding = 0
        public sapp_keycode key_code;

        [FieldOffset(16)] // size = 4, padding = 0
        public uint char_code;

        [FieldOffset(20)] // size = 1, padding = 3
        public CBool key_repeat;

        [FieldOffset(24)] // size = 4, padding = 0
        public uint modifiers;

        [FieldOffset(28)] // size = 4, padding = 0
        public sapp_mousebutton mouse_button;

        [FieldOffset(32)] // size = 4, padding = 0
        public float mouse_x;

        [FieldOffset(36)] // size = 4, padding = 0
        public float mouse_y;

        [FieldOffset(40)] // size = 4, padding = 0
        public float mouse_dx;

        [FieldOffset(44)] // size = 4, padding = 0
        public float mouse_dy;

        [FieldOffset(48)] // size = 4, padding = 0
        public float scroll_x;

        [FieldOffset(52)] // size = 4, padding = 0
        public float scroll_y;

        [FieldOffset(56)] // size = 4, padding = 4
        public int num_touches;

        [FieldOffset(64)] // size = 192, padding = 0
        public fixed ulong _touches[192 / 8]; // sapp_touchpoint[8]

        public Span<sapp_touchpoint> touches
        {
            get
            {
                fixed (sapp_event* @this = &this)
                {
                    var pointer = &@this->_touches[0];
                    var span = new Span<sapp_touchpoint>(pointer, 8);
                    return span;
                }
            }
        }

        [FieldOffset(256)] // size = 4, padding = 0
        public int window_width;

        [FieldOffset(260)] // size = 4, padding = 0
        public int window_height;

        [FieldOffset(264)] // size = 4, padding = 0
        public int framebuffer_width;

        [FieldOffset(268)] // size = 4, padding = 0
        public int framebuffer_height;
    }

    // Struct @ sokol_app.h:1206:3 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    [StructLayout(LayoutKind.Explicit, Size = 24, Pack = 8)]
    public struct sapp_touchpoint
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public UIntPtr identifier;

        [FieldOffset(8)] // size = 4, padding = 0
        public float pos_x;

        [FieldOffset(12)] // size = 4, padding = 0
        public float pos_y;

        [FieldOffset(16)] // size = 1, padding = 7
        public CBool changed;
    }

    // Enum @ sokol_app.h:1378:3 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    public enum sapp_html5_fetch_error : uint
    {
        SAPP_HTML5_FETCH_ERROR_NO_ERROR = 0U,
        SAPP_HTML5_FETCH_ERROR_BUFFER_TOO_SMALL = 1U,
        SAPP_HTML5_FETCH_ERROR_OTHER = 2U
    }

    // Enum @ sokol_app.h:1219:3 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    public enum sapp_mousebutton : uint
    {
        SAPP_MOUSEBUTTON_LEFT = 0U,
        SAPP_MOUSEBUTTON_RIGHT = 1U,
        SAPP_MOUSEBUTTON_MIDDLE = 2U,
        SAPP_MOUSEBUTTON_INVALID = 256U
    }

    // Enum @ sokol_app.h:1190:3 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    public enum sapp_keycode : uint
    {
        SAPP_KEYCODE_INVALID = 0U,
        SAPP_KEYCODE_SPACE = 32U,
        SAPP_KEYCODE_APOSTROPHE = 39U,
        SAPP_KEYCODE_COMMA = 44U,
        SAPP_KEYCODE_MINUS = 45U,
        SAPP_KEYCODE_PERIOD = 46U,
        SAPP_KEYCODE_SLASH = 47U,
        SAPP_KEYCODE_0 = 48U,
        SAPP_KEYCODE_1 = 49U,
        SAPP_KEYCODE_2 = 50U,
        SAPP_KEYCODE_3 = 51U,
        SAPP_KEYCODE_4 = 52U,
        SAPP_KEYCODE_5 = 53U,
        SAPP_KEYCODE_6 = 54U,
        SAPP_KEYCODE_7 = 55U,
        SAPP_KEYCODE_8 = 56U,
        SAPP_KEYCODE_9 = 57U,
        SAPP_KEYCODE_SEMICOLON = 59U,
        SAPP_KEYCODE_EQUAL = 61U,
        SAPP_KEYCODE_A = 65U,
        SAPP_KEYCODE_B = 66U,
        SAPP_KEYCODE_C = 67U,
        SAPP_KEYCODE_D = 68U,
        SAPP_KEYCODE_E = 69U,
        SAPP_KEYCODE_F = 70U,
        SAPP_KEYCODE_G = 71U,
        SAPP_KEYCODE_H = 72U,
        SAPP_KEYCODE_I = 73U,
        SAPP_KEYCODE_J = 74U,
        SAPP_KEYCODE_K = 75U,
        SAPP_KEYCODE_L = 76U,
        SAPP_KEYCODE_M = 77U,
        SAPP_KEYCODE_N = 78U,
        SAPP_KEYCODE_O = 79U,
        SAPP_KEYCODE_P = 80U,
        SAPP_KEYCODE_Q = 81U,
        SAPP_KEYCODE_R = 82U,
        SAPP_KEYCODE_S = 83U,
        SAPP_KEYCODE_T = 84U,
        SAPP_KEYCODE_U = 85U,
        SAPP_KEYCODE_V = 86U,
        SAPP_KEYCODE_W = 87U,
        SAPP_KEYCODE_X = 88U,
        SAPP_KEYCODE_Y = 89U,
        SAPP_KEYCODE_Z = 90U,
        SAPP_KEYCODE_LEFT_BRACKET = 91U,
        SAPP_KEYCODE_BACKSLASH = 92U,
        SAPP_KEYCODE_RIGHT_BRACKET = 93U,
        SAPP_KEYCODE_GRAVE_ACCENT = 96U,
        SAPP_KEYCODE_WORLD_1 = 161U,
        SAPP_KEYCODE_WORLD_2 = 162U,
        SAPP_KEYCODE_ESCAPE = 256U,
        SAPP_KEYCODE_ENTER = 257U,
        SAPP_KEYCODE_TAB = 258U,
        SAPP_KEYCODE_BACKSPACE = 259U,
        SAPP_KEYCODE_INSERT = 260U,
        SAPP_KEYCODE_DELETE = 261U,
        SAPP_KEYCODE_RIGHT = 262U,
        SAPP_KEYCODE_LEFT = 263U,
        SAPP_KEYCODE_DOWN = 264U,
        SAPP_KEYCODE_UP = 265U,
        SAPP_KEYCODE_PAGE_UP = 266U,
        SAPP_KEYCODE_PAGE_DOWN = 267U,
        SAPP_KEYCODE_HOME = 268U,
        SAPP_KEYCODE_END = 269U,
        SAPP_KEYCODE_CAPS_LOCK = 280U,
        SAPP_KEYCODE_SCROLL_LOCK = 281U,
        SAPP_KEYCODE_NUM_LOCK = 282U,
        SAPP_KEYCODE_PRINT_SCREEN = 283U,
        SAPP_KEYCODE_PAUSE = 284U,
        SAPP_KEYCODE_F1 = 290U,
        SAPP_KEYCODE_F2 = 291U,
        SAPP_KEYCODE_F3 = 292U,
        SAPP_KEYCODE_F4 = 293U,
        SAPP_KEYCODE_F5 = 294U,
        SAPP_KEYCODE_F6 = 295U,
        SAPP_KEYCODE_F7 = 296U,
        SAPP_KEYCODE_F8 = 297U,
        SAPP_KEYCODE_F9 = 298U,
        SAPP_KEYCODE_F10 = 299U,
        SAPP_KEYCODE_F11 = 300U,
        SAPP_KEYCODE_F12 = 301U,
        SAPP_KEYCODE_F13 = 302U,
        SAPP_KEYCODE_F14 = 303U,
        SAPP_KEYCODE_F15 = 304U,
        SAPP_KEYCODE_F16 = 305U,
        SAPP_KEYCODE_F17 = 306U,
        SAPP_KEYCODE_F18 = 307U,
        SAPP_KEYCODE_F19 = 308U,
        SAPP_KEYCODE_F20 = 309U,
        SAPP_KEYCODE_F21 = 310U,
        SAPP_KEYCODE_F22 = 311U,
        SAPP_KEYCODE_F23 = 312U,
        SAPP_KEYCODE_F24 = 313U,
        SAPP_KEYCODE_F25 = 314U,
        SAPP_KEYCODE_KP_0 = 320U,
        SAPP_KEYCODE_KP_1 = 321U,
        SAPP_KEYCODE_KP_2 = 322U,
        SAPP_KEYCODE_KP_3 = 323U,
        SAPP_KEYCODE_KP_4 = 324U,
        SAPP_KEYCODE_KP_5 = 325U,
        SAPP_KEYCODE_KP_6 = 326U,
        SAPP_KEYCODE_KP_7 = 327U,
        SAPP_KEYCODE_KP_8 = 328U,
        SAPP_KEYCODE_KP_9 = 329U,
        SAPP_KEYCODE_KP_DECIMAL = 330U,
        SAPP_KEYCODE_KP_DIVIDE = 331U,
        SAPP_KEYCODE_KP_MULTIPLY = 332U,
        SAPP_KEYCODE_KP_SUBTRACT = 333U,
        SAPP_KEYCODE_KP_ADD = 334U,
        SAPP_KEYCODE_KP_ENTER = 335U,
        SAPP_KEYCODE_KP_EQUAL = 336U,
        SAPP_KEYCODE_LEFT_SHIFT = 340U,
        SAPP_KEYCODE_LEFT_CONTROL = 341U,
        SAPP_KEYCODE_LEFT_ALT = 342U,
        SAPP_KEYCODE_LEFT_SUPER = 343U,
        SAPP_KEYCODE_RIGHT_SHIFT = 344U,
        SAPP_KEYCODE_RIGHT_CONTROL = 345U,
        SAPP_KEYCODE_RIGHT_ALT = 346U,
        SAPP_KEYCODE_RIGHT_SUPER = 347U,
        SAPP_KEYCODE_MENU = 348U
    }

    // Enum @ sokol_app.h:1058:3 (/mnt/c/Users/lithi/Programming/sokol-cs/ext/sokol/sokol_app.h)
    public enum sapp_event_type : uint
    {
        SAPP_EVENTTYPE_INVALID = 0U,
        SAPP_EVENTTYPE_KEY_DOWN = 1U,
        SAPP_EVENTTYPE_KEY_UP = 2U,
        SAPP_EVENTTYPE_CHAR = 3U,
        SAPP_EVENTTYPE_MOUSE_DOWN = 4U,
        SAPP_EVENTTYPE_MOUSE_UP = 5U,
        SAPP_EVENTTYPE_MOUSE_SCROLL = 6U,
        SAPP_EVENTTYPE_MOUSE_MOVE = 7U,
        SAPP_EVENTTYPE_MOUSE_ENTER = 8U,
        SAPP_EVENTTYPE_MOUSE_LEAVE = 9U,
        SAPP_EVENTTYPE_TOUCHES_BEGAN = 10U,
        SAPP_EVENTTYPE_TOUCHES_MOVED = 11U,
        SAPP_EVENTTYPE_TOUCHES_ENDED = 12U,
        SAPP_EVENTTYPE_TOUCHES_CANCELLED = 13U,
        SAPP_EVENTTYPE_RESIZED = 14U,
        SAPP_EVENTTYPE_ICONIFIED = 15U,
        SAPP_EVENTTYPE_RESTORED = 16U,
        SAPP_EVENTTYPE_SUSPENDED = 17U,
        SAPP_EVENTTYPE_RESUMED = 18U,
        SAPP_EVENTTYPE_UPDATE_CURSOR = 19U,
        SAPP_EVENTTYPE_QUIT_REQUESTED = 20U,
        SAPP_EVENTTYPE_CLIPBOARD_PASTED = 21U,
        SAPP_EVENTTYPE_FILES_DROPPED = 22U,
        _SAPP_EVENTTYPE_NUM = 23U,
        _SAPP_EVENTTYPE_FORCE_U32 = 2147483647U
    }
}
