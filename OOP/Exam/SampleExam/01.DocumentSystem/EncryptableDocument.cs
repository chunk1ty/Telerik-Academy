using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem_1
{
    public abstract class EncryptableDocument : BinaryDocument, IEncryptable
    {
        public bool IsEncrypted {get; private set;}        

        public void Encrypt()
        {
            this.IsEncrypted = true;
        }

        public void Decrypt()
        {
            this.IsEncrypted = false;
        }

        public override string ToString()
        {
            if (this.IsEncrypted)
            {                
                return this.GetType().Name + "[encrypted]";
            }
            else
            {
                return base.ToString();
            }            
        }
    }
}
