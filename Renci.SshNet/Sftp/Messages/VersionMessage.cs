﻿using System.Collections.Generic;

namespace Renci.SshNet.Sftp.Messages
{
    internal class VersionMessage : SftpMessage
    {
        public VersionMessage()
        {
            this.Extentions = new Dictionary<string, string>();
        }

        public override SftpMessageTypes SftpMessageType
        {
            get { return SftpMessageTypes.Version; }
        }

        public uint Version { get; private set; }

        public IDictionary<string, string> Extentions { get; private set; }

        protected override void LoadData()
        {
            base.LoadData();
            this.Version = this.ReadUInt32();
            this.Extentions = this.ReadExtensionPair();
        }

        protected override void SaveData()
        {
            base.SaveData();
            this.Write(this.Version);
            this.Write(this.Extentions);
        }
    }
}
