using System;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayDelegates.SingleCastDelegate();
            ArrayDelegates.MultiCastDelegate();

            EventHandler.EventImplemet();

        }
    }
}