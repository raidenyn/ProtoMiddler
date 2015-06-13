using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProtoMiddler
{
    public partial class ProtoBufInspectorControl : UserControl
    {
        public ProtoBufInspectorControl()
        {
            InitializeComponent();
        }

        public byte[] ProtobufBytes { get; set; }

        public string ParsedText
        {
            get { return rtbData.Text; }
            protected set { rtbData.Text = value; }
        }

        public string ProtoFile
        {
            get { return txtProtoFile.Text; }
            set { txtProtoFile.Text = value; }
        }

        public string ProtoPath
        {
            get { return txtProtoPath.Text; }
            set { txtProtoPath.Text = value; }
        }

        public IList<string> MessageTypes
        {
            get { return cbMessageType.DataSource as IList<string>; }
            set
            {
                cbMessageType.DataSource = value;
                cbMessageType.Enabled = MessageTypes != null && MessageTypes.Any();
            }
        }

        public string SelectedMessageType
        {
            get { return cbMessageType.Text; }
            set { cbMessageType.Text = value; }
        }


        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            if (protoPathDialog.ShowDialog(this) == DialogResult.OK)
            {
                ProtoPath = protoPathDialog.SelectedPath;
            }
        }

        private void bnBrowse_Click(object sender, EventArgs e)
        {
            protoFileDialog.InitialDirectory = ProtoPath;

            if (DialogResult.OK == protoFileDialog.ShowDialog(this))
            {
                ProtoFile = protoFileDialog.FileName;
            }
        }

        private void txtProtoFile_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(ProtoFile))
            {
                var protoText = File.ReadAllText(ProtoFile);
                MessageTypes = ProtoParser.GetMessages(protoText);
            }
            else
            {
                MessageTypes = null;
            }
        }

        private void cbMessageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parse();
        }

        public void Parse()
        {
            if (ProtobufBytes == null || !ProtobufBytes.Any())
            {
                ParsedText = String.Empty;
                return;
            }

            if (!String.IsNullOrWhiteSpace(SelectedMessageType) &&
                File.Exists(ProtoFile))
            {
                ParsedText = ProtoBufUtil.DecodeWithProto(ProtobufBytes, SelectedMessageType, ProtoFile, ProtoPath);
            }
            else
            {
                ParsedText = ProtoBufUtil.DecodeRaw(ProtobufBytes);
            }
        }

        public void Clear()
        {
            ProtobufBytes = null;
            ParsedText = string.Empty;
        }
    }
}
