using System;
using System.Collections.Generic;
using System.Globalization;

using CostumeRecorder.Core;

namespace CostumeRecorder.Extensions
{
    public static class Utility
    {
        private static readonly CultureInfo ci = new CultureInfo("en-US", false);
        private static string[] exceptions = { "L.Finger.Little", "R.Finger.Little", "TorsoF", "TorsoR", "TorsoS" };
        public static int Round(float value)
        {
            return (int)Math.Round(value);
        }

        public static float ConvertToFloat(string str)
        {
            float.TryParse(str.Replace(',', '.'), NumberStyles.Float, ci, out float retVal);
            return retVal;
        }

        public static float[] GetValuesArray(this List<CostumeJoint> source)
        {
            List<float> result = new List<float>();

            foreach (CostumeJoint joint in source)
            {
                bool skip = false;
                foreach (string name in exceptions)
                {
                    if (name == joint.Name)
                    {
                        skip = true;
                        break;
                    }
                }

                if (skip)
                    continue;

                result.Add(joint.Value);
            }

            return result.ToArray();
        }

        public static string[] GetNamesArray(this List<CostumeJoint> source)
        {
            List<string> result = new List<string>();

            foreach (CostumeJoint joint in source)
            {
                bool skip = false;
                foreach (string name in exceptions)
                {
                    if (name == joint.Name)
                    {
                        skip = true;
                        break;
                    }
                }

                if (skip)
                    continue;

                result.Add(joint.Name);
            }

            return result.ToArray();
        }
    }
}
