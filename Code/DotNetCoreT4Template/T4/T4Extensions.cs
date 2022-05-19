﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//namespace DotNetCoreT4Template.T4
//{
//    internal static class T4Extensions
//    {
//        public static MethodInfo GetMethod(this Type type, string method, params Type[] parameters)
//        {
//            return type.GetRuntimeMethod(method, parameters);
//        }
//    }
//}

namespace System.CodeDom.Compiler
{
    internal class CompilerErrorCollection : List<CompilerError>
    {
    }

    internal class CompilerError
    {
        public string ErrorText { get; set; }

        public bool IsWarning { get; set; }
    }
}