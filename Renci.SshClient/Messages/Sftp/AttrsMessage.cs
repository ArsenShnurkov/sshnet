﻿
namespace Renci.SshClient.Messages.Sftp
{
    internal class AttrsMessage : SftpRequestMessage
    {
        public override SftpMessageTypes SftpMessageType
        {
            get { return SftpMessageTypes.Attrs; }
        }

        public Attributes Attributes { get; set; }

        protected override void LoadData()
        {
            base.LoadData();
            this.Attributes = this.ReadAttributes();
        }

        protected override void SaveData()
        {
            base.SaveData();
            this.Write(this.Attributes);
        }
    }
}
