namespace Traps.RethrowingExceptions
{
    using System;

    public class ExceptionThrower
    {
        public void WithoutStacktrace()
        {
            try
            {
                this.FirstMethod();
            }
            catch (Exception ex)
            {
                Console.WriteLine("==================== WithoutStacktrace() ====== throw ex;");
                throw ex;
            }
        }

        public void WithStacktrace()
        {
            try
            {
                this.FirstMethod();
            }
            catch (Exception)
            {
                Console.WriteLine("==================== WithStacktrace() ====== throw;");
                throw;
            }
        }

        private void FirstMethod()
        {
            this.SecondMethod();
        }

        private void SecondMethod()
        {
            this.ThirdMethod();
        }

        private void ThirdMethod()
        {
            throw new Exception("Exception from ThirdMethod()");
        }
    }
}
