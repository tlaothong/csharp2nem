﻿// ReSharper disable once CheckNamespace

namespace NemApi
{
    public class ImportanceTransferData
    {
        public PublicKey MultisigAccount { get; set; }
        public PublicKey DelegatedAccount { get; set; }
        public bool Activate { get; set; }
        public int Deadline { get; set; }
    }
}