/*This file is part of ProtoMiddler

ProtoMiddler is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.

Foobar is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with Foobar. If not, see http://www.gnu.org/licenses/.
 
Author: Jon Boyd
Email: jboyd[at]securityinnovation[dot]com

 * */

using System;
using System.Diagnostics;
using System.IO;

namespace ProtoMiddler
{
    public static class ProtoBufUtil
    {
        static ProtoBufUtil()
        {
            var currenDir = Path.GetDirectoryName(typeof (ProtoBufUtil).Assembly.Location) ?? @".\";
            var protocPath = Path.Combine(currenDir, @"protoc.exe");

            ProtoCPath = protocPath;
        }

        private static readonly string ProtoCPath;

        public static string DecodeRaw(byte[] protobuf)
        {
            var args = @"--decode_raw";

            return RunProtoc(args, protobuf);
        }

        public static string DecodeWithProto(byte[] protobuf, string messageType, string protoFile, string protoPath)
        {
            var args = String.Format(@"--decode={0} --proto_path=""{1}"" ""{2}""", messageType, protoPath.Trim('\\'), protoFile.Trim('\\'));

            return RunProtoc(args, protobuf);
        }

        private static string RunProtoc(string args, byte[] input)
        {
            ProcessStartInfo procStartInfo = new ProcessStartInfo();
            procStartInfo.FileName = ProtoCPath;
            procStartInfo.Arguments = args;
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.RedirectStandardError = true;
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            Process proc = Process.Start(procStartInfo);

            if (proc == null)
            {
                return "Problems with run protoc.exe";
            }

            string result;

            try
            {
                BinaryWriter binaryWriter = new BinaryWriter(proc.StandardInput.BaseStream);
                binaryWriter.Write(input);
                binaryWriter.Flush();
                binaryWriter.Close();

                result = proc.StandardOutput.ReadToEnd();

                if (String.IsNullOrWhiteSpace(result))
                {
                    result = proc.StandardError.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                result = proc.StandardError.ReadToEnd();

                if (String.IsNullOrWhiteSpace(result))
                {
                    result = e.Message;
                }
            }

            return result;
        }
    }
}
