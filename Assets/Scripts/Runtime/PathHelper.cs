using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PathHelper
{
    public static string GetHotDll { get; } = "Hotfix";
    public static string GetRuntimeDll { get; } = "Runtime";
    public static string GetHotNamespace { get; } = "Hotfix.";
    public static string GetHotDllPath { get; } = "Library/ScriptAssemblies/Hotfix.dll";
    public static string GetRuntimeDllPath { get; } = "./Library/ScriptAssemblies/Runtime.dll";
    public static string GetAutoDictPath { get; } = "Assets/Scripts/Runtime/Auto";
    public static string GetAutoBuildDelegatePath { get; } = $"{GetAutoDictPath}/ILRegType_{0}.cs";
    public static string GetAutoBuildObjectsPath { get; } =  $"{GetAutoDictPath}/GenObjects_{0}.cs";
    public static string GetAutoBuildDelegateBridgePath { get; } = $"{GetAutoDictPath}/GenDelegateBridge_{0}.cs";
}
