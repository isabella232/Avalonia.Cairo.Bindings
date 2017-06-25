using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Cairo.DynLoader
{
    public class NativeDllHelper
    {
        static class Holder<T>
        {
            public static Dictionary<string, T> Dictionary = new Dictionary<string, T>();
        }

        private static IDynLoader _loader;
        private static IntPtr _library;
        private static bool _initialized;


        public static T GetDllImport<T>(string name)
        {
            if (!_initialized)
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    _loader = new Win32Loader();
                    _library = _loader.LoadLibrary("libcairo-2.dll");
                }
                else
                {
                    _loader = new UnixLoader();
                    if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                        _library = _loader.LoadLibrary("libcairo.2.dylib");
                    else
                        _library = _loader.LoadLibrary("libcairo.so.2");
                }
                _initialized = true;
            }
            var dic = Holder<T>.Dictionary;
            T rv;
            if (!dic.TryGetValue(name, out rv))
                dic[name] = rv =
                    Marshal.GetDelegateForFunctionPointer<T>(_loader.GetProcAddress(_library, name, false));
            return rv;
        }
    }
}