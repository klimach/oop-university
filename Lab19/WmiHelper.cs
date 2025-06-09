using System;
using System.Collections.Generic;
using System.Management;

namespace Lab19
{
    public static class WmiHelper
    {
        public static Dictionary<string, string> GetProperties(string wmiClass, params string[] properties)
        {
            var result = new Dictionary<string, string>();
            try
            {
                using var searcher = new ManagementObjectSearcher($"SELECT * FROM {wmiClass}");
                foreach (ManagementObject mo in searcher.Get().Cast<ManagementObject>())
                {
                    foreach (var prop in properties)
                    {
                        var raw = mo.Properties[prop]?.Value;
                        string value = FormatWmiValue(raw);
                        result[prop] = value;
                    }
                    break;
                }
            }
            catch (Exception ex)
            {
                result["ERROR"] = ex.Message;
            }
            return result;
        }

        public static List<Dictionary<string, string>> GetInstances(string wmiClass, params string[] properties)
        {
            var list = new List<Dictionary<string, string>>();
            try
            {
                using var searcher = new ManagementObjectSearcher($"SELECT * FROM {wmiClass}");
                foreach (ManagementObject mo in searcher.Get().Cast<ManagementObject>())
                {
                    var dict = new Dictionary<string, string>();
                    foreach (var prop in properties)
                    {
                        var raw = mo.Properties[prop]?.Value;
                        dict[prop] = FormatWmiValue(raw);
                    }
                    list.Add(dict);
                }
            }
            catch (Exception ex)
            {
                list.Add(new Dictionary<string, string> { ["ERROR"] = ex.Message });
            }
            return list;
        }

        private static string FormatWmiValue(object raw)
        {
            if (raw == null)
                return "";

            if (raw is string[] sa)
                return string.Join(", ", sa);

            if (raw is Array arr)
                return string.Join(", ", arr.Cast<object>().Select(o => o?.ToString()!.Trim()));

            return raw.ToString()!.Trim();
        }
    }
}