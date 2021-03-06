﻿using kkvpn_client.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kkvpn_client
{
    interface IEncryptionEngine
    {
        void Initialize();
        byte[] Encrypt(byte[] data, int? key);
        byte[] Decrypt(byte[] data, int? key);
        int AddKeyToStore(byte[] key);
        void DeleteKeyIfInStore(int? key);
    }
}
