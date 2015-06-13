/*This file is part of ProtoMiddler

ProtoMiddler is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.

Foobar is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with Foobar. If not, see http://www.gnu.org/licenses/.
 
Author: Jon Boyd
Email: jboyd[at]securityinnovation[dot]com

 * */

using System;
using Fiddler;
using System.Windows.Forms;

[assembly: RequiredVersion("2.3.0.0")]
//
// C:\Program Files (x86)\protobuf-net\protobuf-net-VS9>type C:\me\ProtoBufTest\DecodedAccount.txt | protoc.exe --encode=Account --proto_path=C:\me\ProtoBufTest C:\me\ProtoBufTest\Account.proto > c:\me\account.bin
//

namespace ProtoMiddler
{
    public abstract class ProtoBufInspector : Inspector2
    {
        private ProtoBufInspectorControl _myControl;

        protected abstract State StateSettings { get; }

        protected void AssignProtobufBytes(byte[] bytes)
        {
            body = _myControl.ProtobufBytes = bytes;
            
            _myControl.Parse();

            StateSettings.ProtoPath = _myControl.ProtoPath;
            StateSettings.ProtoFile = _myControl.ProtoFile;
            StateSettings.Save();
        }

        public override void AddToTab(TabPage o)
        {
            _myControl = new ProtoBufInspectorControl();
            _myControl.ProtoPath = StateSettings.ProtoPath;
            _myControl.ProtoFile = StateSettings.ProtoFile;
            o.Text = "ProtoBuf";
            o.Controls.Add(_myControl);
            o.Controls[0].Dock = DockStyle.Fill;
        }

        public override int GetOrder()
        {
            return 0;
        }

        public void Clear()
        {
            _myControl.Clear();
        }

        public byte[] body { get; set; }

        public bool bDirty { get { return true; } }

        public bool bReadOnly { get; set; }


        public ProtoBufInspector()
        {
            bReadOnly = false;
        }
    }

    public class ProtoBufRequestInspector : ProtoBufInspector, IRequestInspector2
    {
      
        HTTPRequestHeaders IRequestInspector2.headers { get; set; }

        protected override State StateSettings
        {
            get { return RequestState.Default; }
        }

        public override void AssignSession(Session oSession)
        {
            if (String.IsNullOrWhiteSpace(oSession.oRequest["Content-Type"]) ||
                oSession.oRequest["Content-Type"].ToLower().Contains("protobuf"))
            {
                AssignProtobufBytes(oSession.requestBodyBytes);
            }
            else
            {
                AssignProtobufBytes(null);
            }
        }
    }

    public class ProtoBufResponseInspector : ProtoBufInspector, IResponseInspector2
    {
        protected override State StateSettings
        {
            get { return ResponseState.Default; }
        }

        HTTPResponseHeaders IResponseInspector2.headers { get; set; }

        public override void AssignSession(Session oSession)
        {
            if (String.IsNullOrWhiteSpace(oSession.oResponse["Content-Type"]) ||
                oSession.oResponse["Content-Type"].ToLower().Contains("protobuf"))
            {
                AssignProtobufBytes(oSession.responseBodyBytes);
            }
            else
            {
                AssignProtobufBytes(null);
            }
        }
    }
}
